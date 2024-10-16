using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;
using System.Net.NetworkInformation;
using RentACar.Server;
using RentACar.Common.Model;

namespace RentACar.Server
{
    public class Server
    {
        Socket socket;
        
        public bool isConnected = false;
        private static Server instance;

        public static Server Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Server();
                }
                return instance;
            }
        }

        public  List<ClientHandler> clients = new List<ClientHandler>();
        public static List<Zaposleni> ulogovani = new List<Zaposleni>();
        public Server()
        {
           
        }
        
        public void Start()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));

                socket.Bind(endPoint);
                socket.Listen(5);
                isConnected = true;

                Thread thread = new Thread(AcceptClient);
                thread.IsBackground = true;
                thread.Start();
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void AcceptClient()
        {
            try
            {
                while (isConnected)
                {
                   
                        Socket klijentskiSoket = socket.Accept();
                        ClientHandler handler = new ClientHandler(klijentskiSoket);
                        clients.Add(handler);

                        Thread klijentskaNit = new Thread(handler.HandleRequest);
                        klijentskaNit.IsBackground = true;
                        klijentskaNit.Start();
                    
                  
                   
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>>>>" + ex.Message);
                Stop();
            }
        }
        FrmServer frm = new FrmServer();

        public void Stop()
        {
            try
            {
                socket.Close();
                isConnected = false;

                foreach (ClientHandler handler in clients) { handler.Close(); }
                clients.Clear();
                ulogovani.Clear();
                frm.Dispose();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}