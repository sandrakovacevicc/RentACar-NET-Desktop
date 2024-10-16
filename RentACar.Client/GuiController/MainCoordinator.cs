using RentACar.Client.Forms;
using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RentACar.Client.GuiController
{
    public class MainCoordinator
    {
        private static MainCoordinator instance;
        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }
        private MainCoordinator()
        {
            
            loginGuiController = new LoginGuiController();
            klijentiGuiController = new KlijentiGuiController();
            voziloGuiController = new VoziloGuiController();
            zakazivanjeGuiController = new ZakazivanjeGuiController();

        }

        public FrmMain frmMain;
        private LoginGuiController loginGuiController;
        private KlijentiGuiController klijentiGuiController;
        private VoziloGuiController voziloGuiController; 
        private ZakazivanjeGuiController zakazivanjeGuiController;

        internal void ShowFrmMain()
        {
           
            Communication.Communication.Instance.Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMain = new FrmMain();
            frmMain.MenuStrip1.Visible = false;
            frmMain.Label1.Visible = false;
            frmMain.ChangePanel(loginGuiController.CreateUcLogin());
            frmMain.AutoSize = true;
            Application.Run(frmMain);
        }


        Zaposleni z = new Zaposleni();
        
        internal void ShowHomePage(Zaposleni zaposleni)
        {
         
            frmMain.MenuStrip1.Visible = true;
            frmMain.Label1.Visible = true;
            frmMain.PnlMain.Controls.Clear();
            z = zaposleni;
            frmMain.Label1.Text += " " + zaposleni.Ime + " " + zaposleni.Prezime;
        }



        internal void ShowOdjava()
        {
            Communication.Communication.Instance.Odjavljivanje(z);
            frmMain.MenuStrip1.Visible = false;
            frmMain.Label1.Visible = false;
            frmMain.Label1.Text = "Dobrodosao";
            if (!Communication.Communication.Instance.SocketConnected())
            {
                frmMain.Label1.Text = "";
                frmMain.MenuStrip1.Visible = true;
                frmMain.Label1.Visible = true;
                return;
            }
            else
            {
                frmMain.ChangePanel(loginGuiController.CreateUcLogin());
            }
            
            


        }

        internal void ShowZakazivanja()
        {
            if (!Communication.Communication.Instance.SocketConnected())
            {
                MessageBox.Show("Niste konektovani na server!");
                return;
            }
            frmMain.Label1.Visible = false;
            frmMain.ChangePanel(zakazivanjeGuiController.Prikaz());

        }

        internal void ShowZakazivanjaKI()
        {
            frmMain.Label1.Visible = false;
            frmMain.ChangePanel(zakazivanjeGuiController.Zakazivanje(z));
        }

        internal void ShowKlijenti()
        {
            if (!Communication.Communication.Instance.SocketConnected())
            {
                MessageBox.Show("Niste konektovani na server!");
                return;
            }
            frmMain.Label1.Visible = false;
            frmMain.ChangePanel(klijentiGuiController.VratiKlijente());

        }

        internal void ShowDodajKlijenta() {
            frmMain.Label1.Visible = false;
            frmMain.ChangePanel(klijentiGuiController.KreirajKlijenta());
        }

        internal void ShowIzmeniKlijenta(Klijent klijent)
        {
            frmMain.Label1.Visible = false;
            frmMain.ChangePanel(klijentiGuiController.IzmeniKlijenta(klijent));
        }

        internal void ShowVozila()
        {
            if (!Communication.Communication.Instance.SocketConnected())
            {
                MessageBox.Show("Niste konektovani na server!");
                return;
            }
            frmMain.Label1.Visible = false;
            frmMain.ChangePanel(voziloGuiController.PrikaziVozila());
        }

        internal void ShowDodajVozila()
        {
            frmMain.Label1.Visible = false;
            frmMain.ChangePanel(voziloGuiController.DodajVozilo());
        }

        internal void ShowUcitaj(Klijent izmeni)
        {
            frmMain.Label1.Visible = false;
            frmMain.ChangePanel(klijentiGuiController.Ucitaj(izmeni));
        }

        internal void ShowIzmeniZakazivanje(Zakazivanje izabrano)
        {
            frmMain.Label1.Visible = false;
            frmMain.ChangePanel(zakazivanjeGuiController.Izmena(izabrano));
        }

        internal void ShowObrisiVozilo(Vozilo v)
        {
            frmMain.Label1.Visible = false;
            frmMain.ChangePanel(voziloGuiController.ObrisiVozilo(v));
        }

        internal void ShowUcitajZakazivanje(Zakazivanje izabrano)
        {
            frmMain.Label1.Visible = false;
            frmMain.ChangePanel(zakazivanjeGuiController.Ucitano(izabrano));
        }

        internal void ShowUcitajVozilo(Vozilo v)
        {
            frmMain.Label1.Visible = false;
            frmMain.ChangePanel(voziloGuiController.UcitajVozilo(v));
        }

    
    }
}
