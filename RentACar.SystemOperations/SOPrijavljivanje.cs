using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.SystemOperations
{
    public class SOPrijavljivanje : SystemOperationBase
    {

        public Zaposleni Zaposleni {  get; set; }   
        protected override void ExecuteConcreteOperation()
        {
            Zaposleni z = (Zaposleni)repository.Get(Zaposleni, $"KorisnickoIme = '{Zaposleni.KorisnickoIme}' and lozinka = '{Zaposleni.Lozinka}'");
            Zaposleni = z;

        }
    }
}
