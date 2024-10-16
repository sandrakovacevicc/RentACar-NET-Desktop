using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Common.Communication
{
    public class Sender
    {
        Socket _socket;
        NetworkStream _stream;
        BinaryFormatter _formatter;

        public Sender(Socket socket)
        {
            this._socket = socket;
            _stream = new NetworkStream(socket);
            _formatter = new BinaryFormatter();
        }

        public void Send(object argument)
        {
            _formatter.Serialize(_stream, argument);
        }
    }
}
