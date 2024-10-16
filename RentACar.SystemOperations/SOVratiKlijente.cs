using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.SystemOperations
{
    public class SOVratiKlijente : SystemOperationBase
    {

        public List<Klijent> Klijenti { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Klijenti = repository.GetAll(new Klijent()).OfType<Klijent>().ToList();
        }
    }
}
