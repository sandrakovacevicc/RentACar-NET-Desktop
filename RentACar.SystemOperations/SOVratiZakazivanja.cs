using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.SystemOperations
{
    public class SOVratiZakazivanja : SystemOperationBase
    {
        public List<Zakazivanje> Zakazivanja { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Zakazivanja = repository.GetAll(new Zakazivanje()).OfType<Zakazivanje>().ToList();
        }
    }
}
