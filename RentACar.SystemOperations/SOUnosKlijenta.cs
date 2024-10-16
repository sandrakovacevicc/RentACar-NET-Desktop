using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.SystemOperations
{
    public class SOUnosKlijenta : SystemOperationBase
    {
        public Klijent k;
        protected override void ExecuteConcreteOperation()
        {
            repository.Add(k);
        }
    }
}
