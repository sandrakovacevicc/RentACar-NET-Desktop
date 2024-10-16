using RentACar.Client.GuiController;
using RentACar.Client.UserControls;
using RentACar.Common.Communication;
using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Client.Communication
{
    public class Communication
    {
        private static Communication _instance;

        private Communication() { }

        public static Communication Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Communication();
                }
                return _instance;
            }
        }

        private Socket socket;
        private Sender sender;
        private Receiver receiver;

        public bool connected = false;
       

     

        public void Connect()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                sender = new Sender(socket);
                receiver = new Receiver(socket);
                connected = true;

            }
            catch (SystemException ex)
            {
                
                Debug.WriteLine(ex.Message);    
            }
        }

        public bool SocketConnected()
        {
            return connected && socket != null && socket.Connected && !(socket.Poll(1000, SelectMode.SelectRead) && socket.Available == 0);
        }




        public void Disconnect()
        {
            if (!SocketConnected())
            {
             
                System.Windows.Forms.MessageBox.Show("Niste konektovani na server!");
               
            }
        }

       



        internal Zaposleni Login(string korisnickoIme, string lozinka)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request request = new Request
                {
                    Operation = Operation.Prijavljivanje,
                    Argument = new Zaposleni()
                    {
                        KorisnickoIme = korisnickoIme,
                        Lozinka = lozinka
                    }
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                return response.ParseResponse<Zaposleni>();
            }
            catch (Exception ex)
            {
                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        internal void Odjavljivanje(Zaposleni z)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Argument = z,
                    Operation = Operation.Odjavljivanje
                };
                
                
                sender.Send(req);

                Response response = receiver.Receive<Response>();
                System.Windows.Forms.MessageBox.Show(response.Message);
                

            }
            catch (IOException ex)
            {
                Disconnect();
                Debug.WriteLine(ex.Message);
                
            }
          
        }

        public List<Klijent> VratiKlijente()
        {
            try
            {

                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request { Operation = Operation.VratiKlijente };
                sender.Send(request);
                Response r = receiver.Receive<Response>();
                if (!r.isSuccess) throw new Exception(r.Message);
                return r.ParseResponse<List<Klijent>>();

                
            }
            catch (Exception ex)
            {
                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public List<TipVozila> VratiTipVozila()
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request { Operation = Operation.VratiTipVozila };
                sender.Send(request);
                Response r = receiver.Receive<Response>();
                if (!r.isSuccess) throw new Exception(r.Message);
                return r.ParseResponse<List<TipVozila>>();
            }
            catch (Exception ex)
            {
                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public List<Vozilo> VratiVozila()
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request { Operation = Operation.VratiVozila };
                sender.Send(request);
                Response r = receiver.Receive<Response>();
                if (!r.isSuccess) throw new Exception(r.Message);
                return r.ParseResponse<List<Vozilo>>();
            }
            catch (Exception ex)
            {
                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public void UnosKlijenta(Klijent klijent)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.UnosKlijenta,
                    Argument = new Klijent()
                    {
                        Email = klijent.Email,
                        Ime = klijent.Ime,
                        Prezime = klijent.Prezime,
                        JMBG = klijent.JMBG,
                    }
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                response.ParseResponse<Klijent>(); ;
                if (!response.isSuccess) throw new Exception(response.Message);

                if (response.isSuccess) System.Windows.Forms.MessageBox.Show(response.Message);


            }
            catch (Exception)
            {
                Disconnect();
                
            }

        }

        public void UnosVozila(Vozilo vozilo)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.UnosVozila,
                    Argument = new Vozilo()
                    {

                        Cena = vozilo.Cena,
                        RegistracioniBroj = vozilo.RegistracioniBroj,
                        MarkaVozila = vozilo.MarkaVozila,
                        ModelVozila = vozilo.ModelVozila,
                        Gorivo = vozilo.Gorivo,
                        TipVozila = vozilo.TipVozila,
                    }
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                response.ParseResponse<Vozilo>();
                if (!response.isSuccess) throw new Exception(response.Message);

                if (response.isSuccess) System.Windows.Forms.MessageBox.Show(response.Message);


            }
            catch (Exception)
            {

                Disconnect();
                
            }
        }

        public List<Klijent> PronadjiKlijente(Klijent k)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.PronadjiKlijente,
                    Argument = k

                };
                sender.Send(request);
                Response r = receiver.Receive<Response>();
                if (!r.isSuccess) throw new Exception(r.Message);
                return r.ParseResponse<List<Klijent>>();
                
            }
            catch (Exception ex)
            {
               
                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public void ZapamtiKlijenta(Klijent klijent) {

            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.ZapamtiKlijenta,
                    Argument = klijent
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                response.ParseResponse<Klijent>();
                if (!response.isSuccess) throw new Exception(response.Message);

                if (response.isSuccess) System.Windows.Forms.MessageBox.Show(response.Message);

            }
            catch (Exception)
            {
                Disconnect();
                
            }

        }

        public List<Vozilo> PronadjiVozila(Vozilo v)
        {
            try
            {

                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.PronadjiVozila,
                    Argument = v

                };
                sender.Send(request);
                Response r = receiver.Receive<Response>();
                if (!r.isSuccess) throw new Exception(r.Message);

                return r.ParseResponse<List<Vozilo>>();
            }
            catch (Exception ex)
            {
                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public void ObrisiVozilo(Vozilo vozilo)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request request = new Request
                {
                    Operation = Operation.ObrišiVozilo,
                    Argument = vozilo
                };

                sender.Send(request);

                Response response = receiver.Receive<Response>(); 
                if (!response.isSuccess) throw new Exception(response.Message); 

                System.Windows.Forms.MessageBox.Show(response.Message);

            }
            catch (Exception)
            {
                Disconnect() ;
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da obrise vozilo!");
            }
        }


        public List<Zakazivanje> VratiZakazivanja()
        {
            try
            {

                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request { Operation = Operation.VratiZakazivanje };
                sender.Send(request);
                Response r = receiver.Receive<Response>();
                if (!r.isSuccess) throw new Exception(r.Message);
                return r.ParseResponse<List<Zakazivanje>>();
            }
            catch (Exception ex)
            {
                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public void KreirajZakazivanje(Zakazivanje z)
        {
            try
            {

                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request req = new Request()
                {

                    Operation = Operation.KreirajZakazivanje,
                    Argument = z
                };
                sender.Send(req);

                Response res = receiver.Receive<Response>();
                res.ParseResponse<Zakazivanje>();
                if (!res.isSuccess) throw new Exception(res.Message);

                if (res.isSuccess) System.Windows.Forms.MessageBox.Show(res.Message);

            }
            catch (Exception)
            {
                Disconnect();
                
            }


        }

        public Klijent UcitajKlijenta(Klijent k)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.UčitajKlijenta,
                    Argument = k
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                if (!response.isSuccess) throw new Exception(response.Message);
                return response.ParseResponse<Klijent>();
            }
            catch (Exception ex)
            {
                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public Vozilo UcitajVozilo(Vozilo v)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.UčitajVozilo,
                    Argument = v
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                if (!response.isSuccess) throw new Exception(response.Message);
                if (response.isSuccess) System.Windows.Forms.MessageBox.Show(response.Message);
                return response.ParseResponse<Vozilo>();
            }
            catch (Exception ex)
            {
                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }


        public void ZapamtiZakazivanje(Zakazivanje zakazivanje)
        {
            try
            {

                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.ZapamtiZakazivanje,
                    Argument = zakazivanje
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                if (!response.isSuccess) throw new Exception(response.Message);

                if (response.isSuccess) System.Windows.Forms.MessageBox.Show(response.Message);
                response.ParseResponse<Zakazivanje>();
              

            }
            catch (Exception)
            {
                Disconnect();
                
            }

        }

        public List<Zakazivanje> PronadjiZakazivanja(Zakazivanje z)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.PronadjiZakazivanja,
                    Argument = z

                };
                sender.Send(request);
                Response r = receiver.Receive<Response>();
                if (!r.isSuccess) throw new Exception(r.Message);
                return r.ParseResponse<List<Zakazivanje>>();
            }
            catch (Exception ex)
            {

                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public Zakazivanje UcitajZakazivanje(Zakazivanje z)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");
                Request request = new Request
                {
                    Operation = Operation.UčitajZakazivanje,
                    Argument = z
                };
                sender.Send(request);
                Response response = receiver.Receive<Response>();
                if (!response.isSuccess) throw new Exception(response.Message);
                return response.ParseResponse<Zakazivanje>();
            }
            catch (Exception ex)
            {

                Disconnect();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

       
    }
}
