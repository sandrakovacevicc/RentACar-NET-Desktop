using RentACar.Client.Communication;
using RentACar.Client.UserControls;
using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Client.GuiController
{
    internal class ZakazivanjeGuiController
    {

        UCZakazivanje _ucZakazivanje;
        UCZakazivanjePrikaz _ucZakazivanjePrikaz;
        List<Vozilo> listavozila = new List<Vozilo>();
        Zakazivanje zakazivanje = new Zakazivanje();
        Zaposleni zaposleni = new Zaposleni();

        internal Control Zakazivanje(Zaposleni z)
        {
            _ucZakazivanje = new UCZakazivanje();
            var vozila = Communication.Communication.Instance.VratiVozila();
            _ucZakazivanje.CheckedListVozila.DataSource = vozila;
            listavozila = vozila;
            var klijenti = Communication.Communication.Instance.VratiKlijente();
            _ucZakazivanje.CmbKlijent.DataSource = klijenti;
            _ucZakazivanje.TxtZakazivanje.Enabled = false;
            _ucZakazivanje.TxtIznos.Enabled = false;
            _ucZakazivanje.TxtZakazivanje.Text = z.Ime + " " + z.Prezime;
            zaposleni = z;
            _ucZakazivanje.BtnDodajVozila.Click += DodajVozila;
            _ucZakazivanje.BtnZakazi.Click += Zakazi;

            return _ucZakazivanje;
        }

        private void Zakazi(object sender, EventArgs e)
        {
            if (!Communication.Communication.Instance.SocketConnected())
            {
                MessageBox.Show("Niste konektovani na server!");
                return;
            }

            if (_ucZakazivanje.MonthCalendar1.SelectionStart == DateTime.MinValue || _ucZakazivanje.MonthCalendar2.SelectionStart == DateTime.MinValue)
            {
                MessageBox.Show("Molimo vas izaberite datum zakazivanja.", "Greška pri zakazivanju", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_ucZakazivanje.MonthCalendar1.SelectionStart.Date < DateTime.Today || _ucZakazivanje.MonthCalendar2.SelectionStart.Date < DateTime.Today)
            {
                MessageBox.Show("Datum zakazivanja ne može biti u prošlosti.", "Greška pri zakazivanju", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_ucZakazivanje.MonthCalendar1.SelectionStart.Date > _ucZakazivanje.MonthCalendar2.SelectionStart.Date)
            {
                MessageBox.Show("Datum ne sme biti veci od DatumDo", "Greška pri zakazivanju", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!listavozila.Any(v => _ucZakazivanje.CheckedListVozila.GetItemChecked(_ucZakazivanje.CheckedListVozila.Items.IndexOf(v))))
            {
                MessageBox.Show("Molimo vas izaberite barem jedno vozilo za zakazivanje.", "Greška pri zakazivanju", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Klijent k = (Klijent)_ucZakazivanje.CmbKlijent.SelectedItem;
            zakazivanje.Zaposleni = new Zaposleni();
            zakazivanje.Zaposleni.Id = zaposleni.Id;
            zakazivanje.Klijent = k;
            zakazivanje.Klijent.JMBG = k.JMBG;
            zakazivanje.DatumOd = _ucZakazivanje.MonthCalendar1.SelectionStart;
            zakazivanje.DatumDo = _ucZakazivanje.MonthCalendar2.SelectionStart;

            List<Zakazivanje> zakazivanja = Communication.Communication.Instance.VratiZakazivanja();

            if (k != null)
            {
                DateTime datumOd = _ucZakazivanje.MonthCalendar1.SelectionStart;
                DateTime datumDo = _ucZakazivanje.MonthCalendar2.SelectionStart;

                foreach (var postojeciZakazivanje in zakazivanja)
                {
                    if (postojeciZakazivanje.Klijent.JMBG == k.JMBG && postojeciZakazivanje.DatumOd <= datumDo && postojeciZakazivanje.DatumDo >= datumOd)
                    {
                        MessageBox.Show("Klijent već ima zakazano vozilo za odabrane datume.", "Greška pri zakazivanju", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }


            Communication.Communication.Instance.KreirajZakazivanje(zakazivanje);

            DialogResult result = MessageBox.Show("Da li želite da kreirate još neko zakazivanje?", "Kreiranje zakazivanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MainCoordinator.Instance.ShowZakazivanja();
            }
            else
            {
                _ucZakazivanje.MonthCalendar1.SelectionStart = DateTime.MinValue;
                _ucZakazivanje.MonthCalendar2.SelectionStart = DateTime.MinValue;
                foreach (int index in _ucZakazivanje.CheckedListVozila.CheckedIndices)
                {
                    _ucZakazivanje.CheckedListVozila.SetItemCheckState(index, CheckState.Unchecked);
                }
                _ucZakazivanje.CmbKlijent.SelectedIndex = -1;
                _ucZakazivanje.TxtIznos.Text = "";
            }
        }


        private void DodajVozila(object sender, EventArgs e)
        {
            
            zakazivanje.ListaVozilaZakazivanja = new List<VoziloZakazivanje>();
            zakazivanje.Iznos = 0; 

            for (int i = 0; i < _ucZakazivanje.CheckedListVozila.Items.Count; i++)
            {
                
                if (_ucZakazivanje.CheckedListVozila.GetItemChecked(i))
                {
                    
                    Vozilo vozilo = (Vozilo)_ucZakazivanje.CheckedListVozila.Items[i];
                    VoziloZakazivanje vz = new VoziloZakazivanje();
                    vz.Vozilo = vozilo;
                    zakazivanje.ListaVozilaZakazivanja.Add(vz); 
                    zakazivanje.Iznos += vozilo.Cena;
                }
            }

           
            _ucZakazivanje.TxtIznos.Text = zakazivanje.Iznos.ToString();
        }

        


        internal Control Prikaz()
        {
            _ucZakazivanjePrikaz = new UCZakazivanjePrikaz();
            List<Zakazivanje> zakazivanja = Communication.Communication.Instance.VratiZakazivanja();
          
            _ucZakazivanjePrikaz.DgvKlijenti.DataSource = zakazivanja;
            _ucZakazivanjePrikaz.BtnIzmeniZakazivanje.Visible = false;
            _ucZakazivanjePrikaz.BtnUcitaj.Visible = false;
            _ucZakazivanjePrikaz.BtnDodajZakazivanje.Click += DodajZakazivanje;
            _ucZakazivanjePrikaz.Button1.Click += Pretrazi;
            _ucZakazivanjePrikaz.BtnIzmeniZakazivanje.Click  += (sender, args) => {
                if (_ucZakazivanjePrikaz.DgvKlijenti.SelectedRows.Count > 0)
                {
                    
                    Zakazivanje zakazivanje = (Zakazivanje)_ucZakazivanjePrikaz.DgvKlijenti.SelectedRows[0].DataBoundItem;
                    Zakazivanje izabrano = Communication.Communication.Instance.UcitajZakazivanje(zakazivanje);
                    MessageBox.Show("Sistem je učitao zakazivanje");
                    MainCoordinator.Instance.ShowIzmeniZakazivanje(izabrano);
                }
                else
                {
                    MessageBox.Show("Izaberite zakazivanje");
                }
            };
            _ucZakazivanjePrikaz.BtnUcitaj.Click += (sender, args) => {
                if (_ucZakazivanjePrikaz.DgvKlijenti.SelectedRows.Count > 0)
                {

                    Zakazivanje zakazivanje = (Zakazivanje)_ucZakazivanjePrikaz.DgvKlijenti.SelectedRows[0].DataBoundItem;
                    Zakazivanje izabrano = Communication.Communication.Instance.UcitajZakazivanje(zakazivanje);
                    MessageBox.Show("Sistem je učitao zakazivanje");
                    MainCoordinator.Instance.ShowUcitajZakazivanje(izabrano);
                }
                else
                {
                    MessageBox.Show("Izaberite zakazivanje");
                }
            };

            return _ucZakazivanjePrikaz;
        }

        internal Control Ucitano(Zakazivanje z)
        {
            _ucZakazivanje = new UCZakazivanje();
            var vozila = Communication.Communication.Instance.VratiVozila();
            _ucZakazivanje.CheckedListVozila.DataSource = vozila;
            listavozila = vozila;

            _ucZakazivanje.CmbKlijent.Text = z.Klijent.Ime + " " + z.Klijent.Prezime;
            _ucZakazivanje.CmbKlijent.Enabled = false;
            _ucZakazivanje.TxtZakazivanje.Enabled = false;
            _ucZakazivanje.TxtIznos.Enabled = false;
            _ucZakazivanje.TxtZakazivanje.Text = z.Zaposleni.Ime + " " + z.Zaposleni.Prezime;
            _ucZakazivanje.BtnZakazi.Text = "Vrati se nazad";
            _ucZakazivanje.BtnDodajVozila.Visible = false;

            _ucZakazivanje.MonthCalendar1.SelectionStart = z.DatumOd;
            _ucZakazivanje.MonthCalendar2.SelectionStart = z.DatumDo;
            _ucZakazivanje.TxtIznos.Text = z.Iznos.ToString();

            for (int i = 0; i < _ucZakazivanje.CheckedListVozila.Items.Count; i++)
            {
                Vozilo vozilo = (Vozilo)_ucZakazivanje.CheckedListVozila.Items[i];
                bool zakazano = z.ListaVozilaZakazivanja.Any(vz => vz.Vozilo.RegistracioniBroj == vozilo.RegistracioniBroj);
                if (zakazano)
                {
                    originalnaListaVozila.Add(vozilo);
                }
                _ucZakazivanje.CheckedListVozila.SetItemChecked(i, zakazano);
            }
            _ucZakazivanje.CmbKlijent.Enabled = false;
            _ucZakazivanje.TxtZakazivanje.Enabled = false;
            _ucZakazivanje.TxtIznos.Enabled = false;
            _ucZakazivanje.MonthCalendar1.Enabled = false;
            _ucZakazivanje.MonthCalendar2.Enabled = false;
            _ucZakazivanje.CheckedListVozila.Enabled = false;

        
            _ucZakazivanje.BtnZakazi.Click += (s, a) => MainCoordinator.Instance.ShowZakazivanja();

            return _ucZakazivanje;
        }




        internal Control Izmena(Zakazivanje z)
        {
            _ucZakazivanje = new UCZakazivanje();
           
            var vozila = Communication.Communication.Instance.VratiVozila();
            _ucZakazivanje.CheckedListVozila.DataSource = vozila;
            listavozila = vozila;

            _ucZakazivanje.CmbKlijent.Text = z.Klijent.Ime + " " + z.Klijent.Prezime;
            _ucZakazivanje.CmbKlijent.Enabled = false;
            _ucZakazivanje.TxtZakazivanje.Enabled = false;
            _ucZakazivanje.TxtIznos.Enabled = false;
            _ucZakazivanje.TxtZakazivanje.Text = z.Zaposleni.Ime + " " + z.Zaposleni.Prezime;
            _ucZakazivanje.BtnZakazi.Text = "Izmeni";
            _ucZakazivanje.MonthCalendar1.SelectionStart = z.DatumOd;
            _ucZakazivanje.MonthCalendar2.SelectionStart = z.DatumDo;
            _ucZakazivanje.TxtIznos.Text = z.Iznos.ToString();

           
            for (int i = 0; i < _ucZakazivanje.CheckedListVozila.Items.Count; i++)
            {
                Vozilo vozilo = (Vozilo)_ucZakazivanje.CheckedListVozila.Items[i];
                bool zakazano = z.ListaVozilaZakazivanja.Any(vz => vz.Vozilo.RegistracioniBroj == vozilo.RegistracioniBroj);
                if (zakazano)
                {
                    originalnaListaVozila.Add(vozilo);
                }
                _ucZakazivanje.CheckedListVozila.SetItemChecked(i, zakazano);
            }
            _ucZakazivanje.BtnDodajVozila.Click += DodajVozila;
            _ucZakazivanje.CheckedListVozila.ItemCheck += (sender, args) => ProveraStatusa(sender, args);
            _ucZakazivanje.BtnZakazi.Click += (s, a) => {
                if (_ucZakazivanje.CheckedListVozila.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Morate izabrati barem jedno vozilo!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Izmeni(z);
            };

            return _ucZakazivanje;
        }
        private List<Vozilo> originalnaListaVozila = new List<Vozilo>();

        private void ProveraStatusa(object sender, ItemCheckEventArgs args)
        {
            var selectedVozilo = (Vozilo)((CheckedListBox)sender).SelectedItem;


            if (args.NewValue == CheckState.Checked)
            {
                // Ako je vozilo bilo označeno za brisanje, a sada se ponovo označava, postavi status na Update
                if (listavozila.Contains(selectedVozilo) && selectedVozilo.CrudStatus == CrudStatus.Delete)
                {
                    selectedVozilo.CrudStatus = CrudStatus.Update;
                }
                // Ako je vozilo prethodno bilo označeno, a zatim odznačeno, pa sada ponovo označeno, postavi status na Update
                else if (listavozila.Contains(selectedVozilo) && selectedVozilo.CrudStatus == CrudStatus.Create)
                {
                    // Proveravamo da li je vozilo bilo odznačeno pre nego što se ponovo označi
                    if (!((CheckedListBox)sender).GetItemChecked(((CheckedListBox)sender).SelectedIndex))
                    {
                        selectedVozilo.CrudStatus = CrudStatus.Update;
                    }
                }
                // Ako je vozilo prethodno bilo neoznačeno, a sada se označava, postavi status na Create
                else
                {
                    listavozila.Add(selectedVozilo);
                    selectedVozilo.CrudStatus = CrudStatus.Create;
                }
            }
            // Ako se vozilo odznačava
            else if (args.NewValue == CheckState.Unchecked)
            {
                // Ako je vozilo bilo označeno i nije označeno za kreiranje, postavi status na Delete
                if (listavozila.Contains(selectedVozilo) && selectedVozilo.CrudStatus != CrudStatus.Create)
                {
                    selectedVozilo.CrudStatus = CrudStatus.Delete;
                }
                // Ako je vozilo bilo označeno za kreiranje, a sada se odznačava, ukloni ga iz liste
                else if (listavozila.Contains(selectedVozilo))
                {
                    listavozila.Remove(selectedVozilo);
                    selectedVozilo.CrudStatus = CrudStatus.Update;

                }
                // Ako je vozilo prethodno bilo neoznačeno, a sada se odznačava, postavi status na Update
                else
                {
                    selectedVozilo.CrudStatus = CrudStatus.Update;
                }
            }
           



        }



        private void Izmeni(Zakazivanje z)
        {
          
            if (_ucZakazivanje.MonthCalendar1.SelectionStart == DateTime.MinValue || _ucZakazivanje.MonthCalendar2.SelectionStart == DateTime.MinValue)
            {
                MessageBox.Show("Molimo vas izaberite datum zakazivanja.", "Greška pri izmeni zakazivanja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_ucZakazivanje.MonthCalendar1.SelectionStart.Date < DateTime.Today || _ucZakazivanje.MonthCalendar2.SelectionStart.Date < DateTime.Today)
            {
                MessageBox.Show("Datum zakazivanja ne može biti u prošlosti.", "Greška pri izmeni zakazivanja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            z.Iznos = zakazivanje.Iznos;
            z.DatumOd = _ucZakazivanje.MonthCalendar1.SelectionStart;
            z.DatumDo = _ucZakazivanje.MonthCalendar2.SelectionStart;

            z.ListaVozilaZakazivanja.Clear();
            z.Iznos = 0;
            foreach (Vozilo item in _ucZakazivanje.CheckedListVozila.Items)
            {
                Vozilo vozilo = (Vozilo)item;
                VoziloZakazivanje vz = new VoziloZakazivanje();
                vz.CrudStatus = item.CrudStatus;
                vz.Vozilo = vozilo;
                z.ListaVozilaZakazivanja.Add(vz);

                if (_ucZakazivanje.CheckedListVozila.GetItemChecked(_ucZakazivanje.CheckedListVozila.Items.IndexOf(item)))
                {

                    z.Iznos += vozilo.Cena;
                }
            }

            _ucZakazivanje.TxtIznos.Text = z.Iznos.ToString();
            Communication.Communication.Instance.ZapamtiZakazivanje(z);

       
            MainCoordinator.Instance.ShowZakazivanja();
        }





        private void Pretrazi(object sender, EventArgs e)
        {
            if (!Communication.Communication.Instance.SocketConnected())
            {
                MessageBox.Show("Niste konektovani na server!");
                return;
            }
            DateTime selectedDate = _ucZakazivanjePrikaz.DateTimePicker1.Value.Date;
            string filterString = selectedDate.ToString("yyyy-MM-dd");

            Zakazivanje za = new Zakazivanje()
            {
                SearchQuery = $"CONVERT(date, DatumOd) = '{filterString}' OR CONVERT(date, DatumDo) = '{filterString}'"
            };

            try
            {
                List<Zakazivanje> trazena = Communication.Communication.Instance.PronadjiZakazivanja(za);

                if (trazena != null)
                {
                    MessageBox.Show("Sistem je izvrsio pretragu po zadatim vrednostima");
                    _ucZakazivanjePrikaz.DgvKlijenti.DataSource = trazena;
                    _ucZakazivanjePrikaz.BtnIzmeniZakazivanje.Visible = true;
                    _ucZakazivanjePrikaz.BtnUcitaj.Visible = true;

                }
                else
                {
                    MessageBox.Show("Sistem ne moze da nadje zakazivanja po zadatoj vrednosti");
                  

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nema rezultata za izabrani datum.");
                List<Zakazivanje> zakazivanja = Communication.Communication.Instance.VratiZakazivanja();
                _ucZakazivanjePrikaz.DgvKlijenti.DataSource = zakazivanja;
            }
        }





        private void DodajZakazivanje(object sender, EventArgs e)
        {
            MainCoordinator.Instance.ShowZakazivanjaKI();
        }
    }
}
