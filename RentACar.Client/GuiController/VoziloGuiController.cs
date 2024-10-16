using RentACar.Client.UserControls;
using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Client.GuiController
{
    public class VoziloGuiController
    {
        UCKreirajVozilo _uckreirajVozilo;
        UCPrikaziVozila _ucprikaziVozila;

        List<Vozilo> listavozila = new List<Vozilo>();

        internal Control PrikaziVozila()
        {
           
            _ucprikaziVozila = new UCPrikaziVozila();
            var vozila = Communication.Communication.Instance.VratiVozila();
            if(vozila==null)
            {
                MessageBox.Show("Niste konektovani na server");
            }
            else
            {
                foreach (Vozilo v in vozila)
                {
                    listavozila.Add(v);
                }
            }
            _ucprikaziVozila.DgvVozila.DataSource = vozila;
            _ucprikaziVozila.BtnObrisiVozilo.Visible = false;
            _ucprikaziVozila.BtnDetalji.Visible = false;
            _ucprikaziVozila.BtnDodajVozilo.Click += (sender ,args) =>  MainCoordinator.Instance.ShowDodajVozila();
            _ucprikaziVozila.TxtPretragaV.TextChanged += Pretrazi;
            _ucprikaziVozila.BtnObrisiVozilo.Text = "Obrisi";
            _ucprikaziVozila.BtnObrisiVozilo.Click += (sender, args) => {
                if (_ucprikaziVozila.DgvVozila.SelectedRows.Count > 0)
                {
                   
                    Vozilo obrisi = (Vozilo)_ucprikaziVozila.DgvVozila.SelectedRows[0].DataBoundItem;
                    Vozilo v = Communication.Communication.Instance.UcitajVozilo(obrisi);
                   
                    MainCoordinator.Instance.ShowObrisiVozilo(v);


                }
                else
                {
                    MessageBox.Show("Morate da odaberete vozilo");
                }
            };
            _ucprikaziVozila.BtnDetalji.Click += (sender, args) => {
                if (_ucprikaziVozila.DgvVozila.SelectedRows.Count > 0)
                {

                    Vozilo obrisi = (Vozilo)_ucprikaziVozila.DgvVozila.SelectedRows[0].DataBoundItem;
                    Vozilo v = Communication.Communication.Instance.UcitajVozilo(obrisi);

                    MainCoordinator.Instance.ShowUcitajVozilo(v);


                }
                else
                {
                    MessageBox.Show("Morate da odaberete vozilo");
                }

            };

            return _ucprikaziVozila;

            
        }

        internal Control ObrisiVozilo(Vozilo vozilo)
        {
            _uckreirajVozilo = new UCKreirajVozilo();
            _uckreirajVozilo.Label7.Text = "Obrisi vozilo";
            _uckreirajVozilo.TxtRegBroj.Text = vozilo.RegistracioniBroj;
            _uckreirajVozilo.TxtRegBroj.Enabled = false;
            _uckreirajVozilo.TxtMarka.Text = vozilo.MarkaVozila;
            _uckreirajVozilo.TxtMarka.Enabled = false;
            _uckreirajVozilo.TxtModel.Text = vozilo.ModelVozila;
            _uckreirajVozilo.TxtModel.Enabled = false;
            _uckreirajVozilo.TxtCena.Text = vozilo.Cena.ToString();
            _uckreirajVozilo.TxtCena.Enabled = false;
            _uckreirajVozilo.CmbGoriva.SelectedItem = vozilo.Gorivo;
            _uckreirajVozilo.CmbGoriva.Enabled = false;
            _uckreirajVozilo.CmbTipVozila.Text = vozilo.TipVozila.Naziv;
            _uckreirajVozilo.CmbTipVozila.Enabled = false;
            _uckreirajVozilo.BtnKreirajVozilo.Text = "Obrisi";
           
            _uckreirajVozilo.BtnKreirajVozilo.Click += (s, a) => Obrisi(vozilo);
            
       

           
           
            MainCoordinator.Instance.ShowVozila();
            return _uckreirajVozilo;
        }


        private void Obrisi(Vozilo obrisi)
        {
            try
            {
              
                Communication.Communication.Instance.ObrisiVozilo(obrisi);
                MainCoordinator.Instance.ShowVozila();
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }
            
        }

        private void Pretrazi(object sender, EventArgs e)
        {
            if (!Communication.Communication.Instance.SocketConnected())
            {
                MessageBox.Show("Niste konektovani na server!");
                return;
            }
            string filter = _ucprikaziVozila.TxtPretragaV.Text;
            if (filter.Length > 0)
            {

                Vozilo v = new Vozilo()
                {
                    SearchQuery = $" lower(Vozilo.MarkaVozila) like '%{filter}%' or lower(Vozilo.ModelVozila) like '%{filter}%' or lower(Vozilo.RegistracioniBroj) like '%{filter}%' "
                };
                List<Vozilo> trazenaVozila = Communication.Communication.Instance.PronadjiVozila(v);


              
                _ucprikaziVozila.DgvVozila.DataSource = trazenaVozila;
                _ucprikaziVozila.BtnObrisiVozilo.Visible = true;
                _ucprikaziVozila.BtnDetalji.Visible = true;

                if(trazenaVozila == null)
                {
                    MessageBox.Show("Sistem ne moze da nadje vozila po zadatoj vrednosti!");
                }


            }
            else
            {
                var vozila = Communication.Communication.Instance.VratiVozila();
                _ucprikaziVozila.DgvVozila.DataSource = vozila;


            }
        }

        internal Control DodajVozilo() {

            _uckreirajVozilo = new UCKreirajVozilo();
            List<TipVozila> tipVozila = Communication.Communication.Instance.VratiTipVozila();
            _uckreirajVozilo.BtnKreirajVozilo.Click += UnesiVozilo;
            _uckreirajVozilo.CmbTipVozila.DataSource = tipVozila;
            _uckreirajVozilo.CmbTipVozila.SelectedIndex = -1;

            return _uckreirajVozilo;
        }



        private void UnesiVozilo(object sender, EventArgs e)
        {
            StringBuilder errorMessages = new StringBuilder();
            bool fieldsEmpty = string.IsNullOrEmpty(_uckreirajVozilo.TxtRegBroj.Text) ||
                               string.IsNullOrEmpty(_uckreirajVozilo.TxtMarka.Text) ||
                               string.IsNullOrEmpty(_uckreirajVozilo.TxtModel.Text) ||
                               string.IsNullOrEmpty(_uckreirajVozilo.TxtCena.Text) ||
                               _uckreirajVozilo.CmbGoriva.SelectedIndex == -1 ||
                               _uckreirajVozilo.CmbTipVozila.SelectedIndex == -1;

          
            if (!Communication.Communication.Instance.SocketConnected())
            {
                MessageBox.Show("Niste konektovani na server!");
                return;
            }

        
            _uckreirajVozilo.TxtRegBroj.BackColor = SystemColors.Window;
            _uckreirajVozilo.TxtMarka.BackColor = SystemColors.Window;
            _uckreirajVozilo.TxtModel.BackColor = SystemColors.Window;
            _uckreirajVozilo.TxtCena.BackColor = SystemColors.Window;
            _uckreirajVozilo.CmbGoriva.BackColor = SystemColors.Window;
            _uckreirajVozilo.CmbTipVozila.BackColor = SystemColors.Window;

            
            if (fieldsEmpty)
            {
                errorMessages.AppendLine("Molimo vas popunite sva polja.");

               
                if (string.IsNullOrEmpty(_uckreirajVozilo.TxtRegBroj.Text))
                    _uckreirajVozilo.TxtRegBroj.BackColor = Color.Salmon;
                if (string.IsNullOrEmpty(_uckreirajVozilo.TxtMarka.Text))
                    _uckreirajVozilo.TxtMarka.BackColor = Color.Salmon;
                if (string.IsNullOrEmpty(_uckreirajVozilo.TxtModel.Text))
                    _uckreirajVozilo.TxtModel.BackColor = Color.Salmon;
                if (string.IsNullOrEmpty(_uckreirajVozilo.TxtCena.Text))
                    _uckreirajVozilo.TxtCena.BackColor = Color.Salmon;
                if (_uckreirajVozilo.CmbGoriva.SelectedIndex == -1)
                    _uckreirajVozilo.CmbGoriva.BackColor = Color.Salmon;
                if (_uckreirajVozilo.CmbTipVozila.SelectedIndex == -1)
                    _uckreirajVozilo.CmbTipVozila.BackColor = Color.Salmon;

                MessageBox.Show(errorMessages.ToString(), "Greška pri unosu vozila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

         
            if (!Regex.IsMatch(_uckreirajVozilo.TxtRegBroj.Text, @"^[A-Z]{2}-\d{3,4}-[A-Z]{2}$"))
            {
                errorMessages.AppendLine("Registracioni broj mora biti u formatu dva slova - tri ili četiri cifre - dva slova (npr. AB-123-CD).");
                _uckreirajVozilo.TxtRegBroj.BackColor = Color.Salmon;
                MessageBox.Show(errorMessages.ToString(), "Greška pri unosu vozila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(_uckreirajVozilo.TxtCena.Text, out float cena) || cena <= 0)
            {
                errorMessages.AppendLine("Cena mora biti pozitivan broj.");
                _uckreirajVozilo.TxtCena.BackColor = Color.Salmon;
                MessageBox.Show(errorMessages.ToString(), "Greška pri unosu vozila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            if (_uckreirajVozilo.CmbGoriva.SelectedIndex == -1)
            {
                errorMessages.AppendLine("Izaberite gorivo.");
                _uckreirajVozilo.CmbGoriva.BackColor = Color.Salmon;
                MessageBox.Show(errorMessages.ToString(), "Greška pri unosu vozila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
            if (_uckreirajVozilo.CmbTipVozila.SelectedIndex == -1)
            {
                errorMessages.AppendLine("Izaberite tip vozila.");
                _uckreirajVozilo.CmbTipVozila.BackColor = Color.Salmon;
                MessageBox.Show(errorMessages.ToString(), "Greška pri unosu vozila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (Vozilo vo in listavozila)
            {
                if (vo.RegistracioniBroj == _uckreirajVozilo.TxtRegBroj.Text)
                {
                    errorMessages.AppendLine("Vozilo vec postoji u bazi");
                    MessageBox.Show(errorMessages.ToString(), "Greška pri unosu vozila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }



            Vozilo v = new Vozilo();
            v.RegistracioniBroj = _uckreirajVozilo.TxtRegBroj.Text;
            v.MarkaVozila = _uckreirajVozilo.TxtMarka.Text;
            v.ModelVozila = _uckreirajVozilo.TxtModel.Text;
            v.Cena = float.Parse(_uckreirajVozilo.TxtCena.Text);
            v.Gorivo = _uckreirajVozilo.CmbGoriva.SelectedItem.ToString();
            v.TipVozila = _uckreirajVozilo.CmbTipVozila.SelectedItem as TipVozila;

            Communication.Communication.Instance.UnosVozila(v);

           
            DialogResult result = MessageBox.Show("Da li želite da dodate još neko vozilo?", "Dodavanje vozila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
             
                _uckreirajVozilo.TxtRegBroj.Clear();
                _uckreirajVozilo.TxtMarka.Clear();
                _uckreirajVozilo.TxtModel.Clear();
                _uckreirajVozilo.TxtCena.Clear();
                _uckreirajVozilo.CmbGoriva.SelectedIndex = -1;
                _uckreirajVozilo.CmbTipVozila.SelectedIndex = -1;
                return;
            }

            MainCoordinator.Instance.ShowVozila();
        }


        internal Control UcitajVozilo(Vozilo v)
        {
           

            _uckreirajVozilo = new UCKreirajVozilo();
            _uckreirajVozilo.Label7.Text = "Detalji o vozilu";
            _uckreirajVozilo.TxtRegBroj.Text = v.RegistracioniBroj;
            _uckreirajVozilo.TxtRegBroj.Enabled = false;
            _uckreirajVozilo.TxtMarka.Text = v.MarkaVozila;
            _uckreirajVozilo.TxtMarka.Enabled = false;
            _uckreirajVozilo.TxtModel.Text = v.ModelVozila;
            _uckreirajVozilo.TxtModel.Enabled = false;
            _uckreirajVozilo.TxtCena.Text = v.Cena.ToString();
            _uckreirajVozilo.TxtCena.Enabled = false;
            _uckreirajVozilo.CmbGoriva.SelectedItem = v.Gorivo;
            _uckreirajVozilo.CmbGoriva.Enabled = false;
            _uckreirajVozilo.CmbTipVozila.Text = v.TipVozila.Naziv;
            _uckreirajVozilo.CmbTipVozila.Enabled = false;
            _uckreirajVozilo.BtnKreirajVozilo.Text = "Vrati se nazad";

            _uckreirajVozilo.BtnKreirajVozilo.Click += (s, a) => MainCoordinator.Instance.ShowVozila();





            return _uckreirajVozilo;
        }
    }
}
