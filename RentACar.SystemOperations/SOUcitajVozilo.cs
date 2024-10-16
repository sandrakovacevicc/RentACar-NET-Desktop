using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.SystemOperations
{
    public class SOUcitajVozilo : SystemOperationBase
    {
        public Vozilo Vozilo;

        protected override void ExecuteConcreteOperation()
        {
            Vozilo = (Vozilo)repository.Get(new Vozilo(), $"RegistracioniBroj ='{Vozilo.RegistracioniBroj}'");
        }
    }
}
