using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.SystemOperations
{
    public class SOVratiZakazivanje : SystemOperationBase
    {
        public List<Zakazivanje> zakazivanja;
        protected override void ExecuteConcreteOperation()
        {
            zakazivanja = repository.GetAll(new Zakazivanje()).OfType<Zakazivanje>().ToList();
        }
    }
}
