using RentACar.Common.Communication;
using RentACar.Common.Model;
using RentACar.SystemOperations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Server
{
    public class ClientHandler
    {
        readonly Socket _socket;
        readonly Sender _sender;
        readonly Receiver _receiver;


        public ClientHandler(Socket socket)
        {
            this._socket = socket;
            _sender = new Sender(socket);
            _receiver = new Receiver(socket);
                
        }

        internal void HandleRequest()
        {
            try
            {

                while (true)
                {
                    Request r = _receiver.Receive<Request>();
                    Response response = ProcessRequest(r);
                    _sender.Send(response);
                }
            }
            catch (SocketException ex)
            {

                Debug.WriteLine(">>>" + ex.Message);
            }
            catch(IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
                Server.Instance.clients.Remove(this);
            }
        }

        public void Close()
        {
            _socket.Close();
        }

        Zaposleni zaposleni;

        private Response ProcessRequest(Request r)
        {
            Response response = new Response();
            try
            {
                response.isSuccess = true;
                switch (r.Operation)
                {
                    case Operation.Prijavljivanje:
                        zaposleni = (Zaposleni)Controller.Instance.Login((Zaposleni)r.Argument);
                        if (zaposleni != null)
                        {
                            if (!Server.ulogovani.Contains(zaposleni))
                            {
                                response.Result = Controller.Instance.Login((Zaposleni)r.Argument);
                                response.Message = "Uspesno ste se prijavili na sistem!";
                                response.isSuccess = true;
                                Server.ulogovani.Add(zaposleni);
                            }
                            else
                            {
                                response.isSuccess = false;
                                response.Message = "Neuspesno prijavljivanje na sistem!";
                            }

                        }
                        else
                        {
                            response.isSuccess = false;
                            response.Message = "Neuspesno prijavljivanje na sistem!";
                        }
                        
                        break;

                    case Operation.Odjavljivanje:

                        zaposleni = (Zaposleni)r.Argument;
                        Server.ulogovani.Remove(zaposleni);
                        zaposleni = null;

                        response.Message = "Korisnik je odjavljen sa profila";

                        break;

                    case Operation.VratiKlijente:
                        response.Result = Controller.Instance.VratiKlijente();
                        response.Message = "Vraceni svi klijenti!";
                        break;

                    case Operation.VratiTipVozila:
                        response.Result = Controller.Instance.VratiTipVozila();
                        response.Message = "Vraceni svi tipovi vozila!";
                        break;
                    case Operation.VratiVozila:
                        response.Result = Controller.Instance.VratiVozila();
                        response.Message = "Vracena sva vozila!";
                        break;
                    case Operation.UnosKlijenta:
                       
                        Klijent novi = Controller.Instance.UnosKlijenta((Klijent)r.Argument);
                        if(novi != null)
                        {
                            response.Message = "Podaci o novom klijentu su sacuvani!";
                            response.isSuccess = true;
                        }
                        else
                        {
                            response.Message = "Sistem ne moze da sacuva novog klijenta!";
                            response.isSuccess = false;
                        }
                        
                        break;
                    case Operation.UnosVozila:
                        Vozilo novo = Controller.Instance.UnosVozila((Vozilo)r.Argument);
                        if (novo != null)
                        {
                            response.Message = "Uspesno kreirano vozilo!";
                            response.isSuccess = true;
                        }
                        else
                        {
                            response.Message = "Sistem ne moze da kreira vozilo!";
                            response.isSuccess = false;
                        }
                        break;

                    case Operation.PronadjiKlijente:
                        response.Result = Controller.Instance.PronadjiKlijente((Klijent)r.Argument);
                        response.Message = "Sistem je vratio klijente po zadatoj vrednosti!";
                        break;
                    case Operation.ZapamtiKlijenta:
                        Controller.Instance.ZapamtiKlijenta((Klijent)r.Argument);
                        response.Message = "Klijent je uspesno izmenjen!";
                        break;
                    case Operation.PronadjiVozila:
                        response.Result = Controller.Instance.PronadjiVozila((Vozilo)r.Argument);
                        response.Message = "Sistem je vratio vozila po zadatoj vrednosti!";
                        break;
                    case Operation.ObrišiVozilo:
                        Controller.Instance.Obrisi((Vozilo)r.Argument);
                        response.Message = "Vozilo je obrisano!";
                        break;
                    case Operation.VratiZakazivanje:
                        response.Result = Controller.Instance.VratiZakazivanja();
                        response.Message = "Sistem je vratio zakazivanja!";
                        break;
                    case Operation.KreirajZakazivanje:
                        Zakazivanje z = Controller.Instance.KreirajZakazivanje((Zakazivanje)r.Argument);
                        if (z != null)
                        {
                            response.Message = "Sistem je kreirao zakazivanje!";
                            response.isSuccess = true;
                        }
                        else
                        {
                            response.Message = "Sistem ne moze da kreira zakazivanje!";
                            response.isSuccess = false;
                        }
                       
                        break;
                    case Operation.UčitajKlijenta:
                        Klijent k = Controller.Instance.UcitajKlijenta((Klijent)r.Argument);
                        if(k != null)
                        {
                            response.Result = k;
                            response.Message = "Sistem je učitao klijenta!";
                            response.isSuccess = true;
                        }
                        else
                        {
                            response.Message = "Sistem ne moze da ucita klijenta!";
                            response.isSuccess = false;
                        }
                        
                        break;
                    case Operation.UčitajVozilo:
                        Vozilo vozilo = Controller.Instance.UcitajVozilo((Vozilo)r.Argument);
                        if(vozilo != null) {
                            response.Result = vozilo;
                            response.Message = "Sistem je učitao vozilo!";
                            response.isSuccess = true;
                        }
                        else
                        {
                            response.Message = "Sistem ne moze da ucita vozilo!";
                            response.isSuccess = false;
                        }
                       
                        break;
                    case Operation.ZapamtiZakazivanje:
                        Controller.Instance.IzmeniZakazivanje((Zakazivanje)r.Argument);
                        response.Message = "Sistem je izmenio zakazivanje!";
                        break;
                    case Operation.PronadjiZakazivanja:
                        response.Result = Controller.Instance.PronadjiZakazivanja((Zakazivanje)r.Argument);
                        response.Message = "Sistem je vratio zakazivanja po zadatoj vrednosti!";
                        break;
                    case Operation.UčitajZakazivanje:
                        Zakazivanje za = Controller.Instance.UcitajZakazivanje((Zakazivanje)r.Argument);
                        if (za != null)
                        {
                            response.Result = za;
                            response.Message = "Sistem je učitao zakazivanje!";
                            response.isSuccess = true;
                        }
                        else
                        {
                            response.Message = "Sistem ne moze da ucita zakazivanje!";
                            response.isSuccess = false;
                        }
                        break;
                  
                    default:
                        response.Exception = new Exception("Operation is not yet implemented!");
                        break;
                }
            }
            catch (Exception ex)
            {
                response.isSuccess = false;
                response.Exception = new Exception(ex.Message);
            }
            return response;
        }
    }
}
