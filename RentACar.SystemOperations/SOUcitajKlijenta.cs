using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.SystemOperations
{
    public class SOUcitajKlijenta : SystemOperationBase
    {
        public Klijent klijent;

        protected override void ExecuteConcreteOperation()
        {
            klijent = (Klijent)repository.Get(new Klijent(), $"JMBG ='{klijent.JMBG}'");
        }
    }
}
