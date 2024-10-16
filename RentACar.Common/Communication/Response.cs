using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Common.Communication
{
    [Serializable]
    public class Response
    {
        public object Result { get; set; }
        public Exception Exception { get; set; }

        public string Message { get; set; } 
        public bool isSuccess { get; set; } 
        
    }
}
