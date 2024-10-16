using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.SystemOperations
{
    public class SOPronadjiVozila : SystemOperationBase
    {
        public Vozilo vozilo;
        public List<Vozilo> voziloList;    
        protected override void ExecuteConcreteOperation()
        {
            voziloList = repository.Search(vozilo, vozilo.SearchQuery).Cast<Vozilo>().ToList(); 
        }
    }
}
