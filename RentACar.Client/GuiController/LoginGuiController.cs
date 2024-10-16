using RentACar.Client.UserControls;
using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Client.GuiController
{
    public class LoginGuiController
    {

        private UCLogin _ucLogin;

        public LoginGuiController()
        {
        

            

        }

        internal Control CreateUcLogin()
        {
            _ucLogin = new UCLogin();
            _ucLogin.BtnLogin.Click += Login;
            return _ucLogin;
        }

        private void Login(object sender, EventArgs e)
        {
            try
            {
                string username = _ucLogin.TxtKorisnickoIme.Text;
                string password = _ucLogin.TxtLozinka.Text;

                if (!Valid()) return;


                
                Zaposleni zaposleni = Communication.Communication.Instance.Login(username, password);
                if (zaposleni == null)
                {
                   MessageBox.Show("Neuspesno prijavljivanje na sistem!");
                }
                else
                {
                    MessageBox.Show("Uspesno prijavljivanje na sistem!");
                    MainCoordinator.Instance.ShowHomePage(zaposleni);
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspesno prijavljivanje na sistem!");
                return;
            }
        }

        private bool Valid()
        {
            string username = _ucLogin.TxtKorisnickoIme.Text;
            string password = _ucLogin.TxtLozinka.Text;
            _ucLogin.TxtKorisnickoIme.BackColor = Color.White;
            _ucLogin.TxtLozinka.BackColor = Color.White;

            string message = "";
            if (string.IsNullOrEmpty(username))
            {
                message += "Username ne sme biti prazan!\n";
                _ucLogin.TxtKorisnickoIme.BackColor = Color.LightCoral;
            }
            if (string.IsNullOrEmpty(password) || password.Length < 3)
            {
                message += "Password mora biti duzi od 3 karaktera!\n";
                _ucLogin.TxtLozinka.BackColor = Color.LightCoral;
            }
            if (message != "")
            {
                MessageBox.Show(message);
                return false;
            }
            return true;
        }
    }
}
