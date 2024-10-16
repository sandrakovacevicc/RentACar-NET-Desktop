using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RentACar.SystemOperations
{
    public class SOPronadjiKlijente : SystemOperationBase
    {
        public Klijent klijent;
        public List<Klijent> VraceniKlijenti;
        protected override void ExecuteConcreteOperation()
        {
            VraceniKlijenti = repository.Search(klijent, klijent.SearchQuery).Cast<Klijent>().ToList();
        }
    }
}
