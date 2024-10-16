using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.SystemOperations
{
    public class SOZapamtiKlijenta : SystemOperationBase
    {
        public Klijent Klijent;
        protected override void ExecuteConcreteOperation()
        {
            repository.Update(Klijent, $"JMBG = '{Klijent.JMBG}'");
        }
    }
}
