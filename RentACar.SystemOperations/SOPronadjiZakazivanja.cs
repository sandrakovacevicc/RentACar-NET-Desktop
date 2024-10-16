using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.SystemOperations
{
    public class SOPronadjiZakazivanja : SystemOperationBase
    {
        public Zakazivanje zakazivanje;
        public List<Zakazivanje> listazakazivanja;
        protected override void ExecuteConcreteOperation()
        {
            listazakazivanja = repository.Search(zakazivanje, zakazivanje.SearchQuery).Cast<Zakazivanje>().ToList();
        }
    }
}
