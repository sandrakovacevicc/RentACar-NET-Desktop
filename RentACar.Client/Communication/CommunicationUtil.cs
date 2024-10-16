using RentACar.Common.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Client.Communication
{
    public static class CommunicationUtil
    {

        public  static T ParseResponse<T>(this Response response)
        {
           if(response.Exception == null)
            {
                return (T)response.Result;
            }
            else{
                throw response.Exception;
            }
        }
    }
}
