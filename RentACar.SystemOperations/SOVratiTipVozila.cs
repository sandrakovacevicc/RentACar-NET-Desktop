using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.SystemOperations
{
    public class SOVratiTipVozila : SystemOperationBase
    {

        public List<TipVozila> TipoviVozila { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            TipoviVozila = repository.GetAll(new TipVozila()).OfType<TipVozila>().ToList();
        }
    }
}
