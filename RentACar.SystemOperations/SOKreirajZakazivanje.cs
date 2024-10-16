using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RentACar.SystemOperations
{
    public class SOKreirajZakazivanje : SystemOperationBase
    {
        public Zakazivanje zakazivanje;
        protected override void ExecuteConcreteOperation()
        {
            int zakazivanjeID = int.Parse(repository.Add(zakazivanje).ToString());
            zakazivanje.ZakazivanjeId = zakazivanjeID;

            if (zakazivanje.ZakazivanjeId == 0) throw new Exception("Greska u dodavanju zakazivanja");
            foreach (VoziloZakazivanje vz in zakazivanje.ListaVozilaZakazivanja)
            {
                vz.Zakazivanje = zakazivanje;
                
                repository.Add(vz);
            }
        }
    }
}
