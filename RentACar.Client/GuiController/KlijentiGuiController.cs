using RentACar.Client.Communication;
using RentACar.Client.UserControls;
using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Client.GuiController
{
    internal class KlijentiGuiController
    {
        UCPrikaziKlijente _ucprikaziKlijente;
        UCKreirajKlijenta _uckreirajKlijenta;

      

        internal Control VratiKlijente()
        {
            _ucprikaziKlijente = new UCPrikaziKlijente();
            List<Klijent> klijenti = Communication.Communication.Instance.VratiKlijente();
            _ucprikaziKlijente.DgvKlijenti.DataSource = klijenti;
            listaKlijenata = klijenti;
            _ucprikaziKlijente.TxtPretraga.TextChanged += Pretrazi;
            _ucprikaziKlijente.BtnDetalji.Click += (sender, args) =>
            {
                if (_ucprikaziKlijente.DgvKlijenti.SelectedRows.Count > 0)
                {

                    Klijent ucitaj = (Klijent)_ucprikaziKlijente.DgvKlijenti.SelectedRows[0].DataBoundItem;
                    Klijent k = Communication.Communication.Instance.UcitajKlijenta(ucitaj);
                    MessageBox.Show("Sistem je ucitao klijenta");
                    MainCoordinator.Instance.ShowUcitaj(k);

                }
                else
                {
                    MessageBox.Show("Morate da odaberete klijenta");
                }
            };
                _ucprikaziKlijente.BtnDodajKlijenta.Click += (sender, args) => MainCoordinator.Instance.ShowDodajKlijenta();
                _ucprikaziKlijente.BtnDetalji.Visible = false;
                _ucprikaziKlijente.BtnIzmeniKlijenta.Visible = false;
                _ucprikaziKlijente.BtnIzmeniKlijenta.Click += (sender, args) => {
                if (_ucprikaziKlijente.DgvKlijenti.SelectedRows.Count > 0)
                {
                  
                    Klijent izmeni = (Klijent)_ucprikaziKlijente.DgvKlijenti.SelectedRows[0].DataBoundItem;
                    MessageBox.Show("Sistem je učitao klijenta");
                    MainCoordinator.Instance.ShowIzmeniKlijenta(izmeni);
                }
                else
                {
                    MessageBox.Show("Morate da odaberete klijenta");
                }
            };

            return _ucprikaziKlijente;
        }

       

        private void Pretrazi(object sender, EventArgs e)
        {
            if (!Communication.Communication.Instance.SocketConnected())
            {
                MessageBox.Show("Niste konektovani na server!");
                return;
            }


            string filter = _ucprikaziKlijente.TxtPretraga.Text;
                if (filter.Length > 0)
                {

                    Klijent k = new Klijent()
                    {
                        SearchQuery = $" lower(Klijent.Ime) like '%{filter}%' or lower(Klijent.Prezime) like '%{filter}%' or lower(Klijent.JMBG) like '%{filter}%' "
                    };
                    List<Klijent> trazeniKlijenti = Communication.Communication.Instance.PronadjiKlijente(k);
                    
                   
                    
                    _ucprikaziKlijente.DgvKlijenti.DataSource = trazeniKlijenti;
                    _ucprikaziKlijente.BtnDetalji.Visible = true;
                    _ucprikaziKlijente.BtnIzmeniKlijenta.Visible = true;

                if(trazeniKlijenti == null)
                {
                    MessageBox.Show("Sistem ne moze da nadje klijente po zadatoj vrednosti");
                }



            }
                else
                {
                    List<Klijent> klijenti = Communication.Communication.Instance.VratiKlijente();
                    _ucprikaziKlijente.DgvKlijenti.DataSource = klijenti;
                    
                
        
                }
            
     
            

            
            
            

        }
        public List<Klijent> listaKlijenata = new List<Klijent>();

        internal Control Ucitaj(Klijent klijent)
        {
            _uckreirajKlijenta = new UCKreirajKlijenta();
            _uckreirajKlijenta.Label5.Text = "Detalji o klijentu";
            _uckreirajKlijenta.BtnKreirajKlijenta.Visible = false;
            _uckreirajKlijenta.TxtJMBG.Text = klijent.JMBG;
            _uckreirajKlijenta.TxtJMBG.ReadOnly = true;
            _uckreirajKlijenta.TxtIme.Text = klijent.Ime;
            _uckreirajKlijenta.TxtIme.ReadOnly = true;
            _uckreirajKlijenta.TxtPrezime.Text = klijent.Prezime;
            _uckreirajKlijenta.TxtPrezime.ReadOnly = true;
            _uckreirajKlijenta.TxtMail.Text = klijent.Email;
            _uckreirajKlijenta.TxtMail.ReadOnly = true;
            _uckreirajKlijenta.BtnIzmeniKlijenta.Text = "Vrati se nazad";
            _uckreirajKlijenta.BtnIzmeniKlijenta.Click += Vrati;
            return _uckreirajKlijenta;
        }

        private void Vrati(object sender, EventArgs e)
        {
            MainCoordinator.Instance.ShowKlijenti();
        }

        internal Control KreirajKlijenta()
        {
            _uckreirajKlijenta = new UCKreirajKlijenta();
            _uckreirajKlijenta.BtnIzmeniKlijenta.Visible = false;
            _uckreirajKlijenta.BtnKreirajKlijenta.Click += DodajKlijenta;
            return _uckreirajKlijenta;
        }

        public void DodajKlijenta(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (!Communication.Communication.Instance.SocketConnected())
            {
                MessageBox.Show("Niste konektovani na server!");
                return;
            }

            if (string.IsNullOrWhiteSpace(_uckreirajKlijenta.TxtJMBG.Text) ||
                string.IsNullOrWhiteSpace(_uckreirajKlijenta.TxtIme.Text) ||
                string.IsNullOrWhiteSpace(_uckreirajKlijenta.TxtPrezime.Text) ||
                string.IsNullOrWhiteSpace(_uckreirajKlijenta.TxtMail.Text))
            {
                sb.AppendLine("Molimo vas popunite sva polja.");
                _uckreirajKlijenta.TxtJMBG.BackColor = Color.Salmon;
                _uckreirajKlijenta.TxtIme.BackColor = Color.Salmon;
                _uckreirajKlijenta.TxtPrezime.BackColor = Color.Salmon;
                _uckreirajKlijenta.TxtMail.BackColor = Color.Salmon;
            }
            else
            {
                _uckreirajKlijenta.TxtJMBG.BackColor = SystemColors.Window;
                _uckreirajKlijenta.TxtIme.BackColor = SystemColors.Window;
                _uckreirajKlijenta.TxtPrezime.BackColor = SystemColors.Window;
                _uckreirajKlijenta.TxtMail.BackColor = SystemColors.Window;
            }
           

            if (_uckreirajKlijenta.TxtJMBG.Text.Length != 13)
            {
                sb.AppendLine("JMBG mora imati tačno 13 karaktera.");
                _uckreirajKlijenta.TxtJMBG.BackColor = Color.Salmon;
            }

            if (_uckreirajKlijenta.TxtIme.Text.Any(char.IsDigit) || _uckreirajKlijenta.TxtPrezime.Text.Any(char.IsDigit))
            {
                sb.AppendLine("Ime i prezime ne smeju sadržati brojeve.");
                _uckreirajKlijenta.TxtIme.BackColor = Color.Salmon;
                _uckreirajKlijenta.TxtPrezime.BackColor = Color.Salmon;
            }

            if (!Regex.IsMatch(_uckreirajKlijenta.TxtMail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                sb.AppendLine("Molimo vas unesite validan mejl.");
                _uckreirajKlijenta.TxtMail.BackColor = Color.Salmon;
            }

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach(Klijent kl in listaKlijenata)
            {
                if(kl.JMBG == _uckreirajKlijenta.TxtJMBG.Text)
                {
                    MessageBox.Show("Klijent vec postoji u bazi!");
                    return;
                }

            }
           

            Klijent k = new Klijent();
            k.JMBG = _uckreirajKlijenta.TxtJMBG.Text;
            k.Email = _uckreirajKlijenta.TxtMail.Text;
            k.Ime = _uckreirajKlijenta.TxtIme.Text;
            k.Prezime = _uckreirajKlijenta.TxtPrezime.Text;
            Communication.Communication.Instance.UnosKlijenta(k);

            DialogResult result = MessageBox.Show("Želite li da dodate još jednog klijenta?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _uckreirajKlijenta.TxtJMBG.Text = "";
                _uckreirajKlijenta.TxtMail.Text = "";
                _uckreirajKlijenta.TxtIme.Text = "";
                _uckreirajKlijenta.TxtPrezime.Text = "";
            }
            else
            {
                MainCoordinator.Instance.ShowKlijenti();
            }
        }





        internal Control IzmeniKlijenta(Klijent klijent)
        {
            _uckreirajKlijenta = new UCKreirajKlijenta();
            _uckreirajKlijenta.Label5.Text = "Izmeni klijenta";
            _uckreirajKlijenta.BtnKreirajKlijenta.Visible = false;
            _uckreirajKlijenta.TxtJMBG.Text = klijent.JMBG;
            _uckreirajKlijenta.TxtJMBG.ReadOnly = true;
            _uckreirajKlijenta.TxtIme.Text = klijent.Ime;
            _uckreirajKlijenta.TxtPrezime.Text = klijent.Prezime;
            _uckreirajKlijenta.TxtMail.Text = klijent.Email;
            _uckreirajKlijenta.BtnIzmeniKlijenta.Click += Zapamti;
            return _uckreirajKlijenta;
        }

        private void Zapamti(object sender, EventArgs e)
        {
            StringBuilder errorMessages = new StringBuilder();
            if (!Communication.Communication.Instance.SocketConnected())
            {
                MessageBox.Show("Niste konektovani na server!");
                return;
            }

            if (string.IsNullOrEmpty(_uckreirajKlijenta.TxtJMBG.Text) || _uckreirajKlijenta.TxtJMBG.Text.Length != 13)
            {
                errorMessages.AppendLine("JMBG mora imati tačno 13 karaktera.");
                _uckreirajKlijenta.TxtJMBG.BackColor = Color.Salmon;
            }
            else
            {
                _uckreirajKlijenta.TxtJMBG.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(_uckreirajKlijenta.TxtMail.Text) || !_uckreirajKlijenta.TxtMail.Text.Contains("@"))
            {
                errorMessages.AppendLine("Mejl mora sadržati znak '@'.");
                _uckreirajKlijenta.TxtMail.BackColor = Color.Salmon;
            }
            else
            {
                _uckreirajKlijenta.TxtMail.BackColor = SystemColors.Window;
            }

            if (errorMessages.Length > 0)
            {
                MessageBox.Show(errorMessages.ToString(), "Greška pri unosu klijenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Klijent k = new Klijent();
            k.JMBG = _uckreirajKlijenta.TxtJMBG.Text;
            k.Ime = _uckreirajKlijenta.TxtIme.Text;
            k.Prezime = _uckreirajKlijenta.TxtPrezime.Text;
            k.Email = _uckreirajKlijenta.TxtMail.Text;
            Communication.Communication.Instance.ZapamtiKlijenta(k);
            MainCoordinator.Instance.ShowKlijenti();
        }




    }
}
