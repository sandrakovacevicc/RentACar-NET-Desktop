using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Common.Communication
{
    public class Receiver
    {
        Socket _socket;
        NetworkStream _stream;
        BinaryFormatter _formatter;

        public Receiver(Socket socket)
        {
            this._socket = socket;
            this._stream = new NetworkStream(socket);
            this._formatter = new BinaryFormatter();
                
        }

        public T Receive<T>() where T : class
        {
            return (T)_formatter.Deserialize(_stream);
        }
    }
}
