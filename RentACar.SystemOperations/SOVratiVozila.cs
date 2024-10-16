using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.SystemOperations
{
    public class SOVratiVozila : SystemOperationBase
    {
        public List<Vozilo> Vozila { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Vozila = repository.GetAll(new Vozilo()).OfType<Vozilo>().ToList();
        }
    }
}
