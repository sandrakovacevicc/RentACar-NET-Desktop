using RentACar.Common.Model;
using RentACar.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace RentACar.SystemOperations
{
    public class SOIzmeniZakazivanje : SystemOperationBase
    {
        public Zakazivanje zakazivanje;
        
        protected override void ExecuteConcreteOperation()
        {
            repository.Update(zakazivanje, $" zakazivanjeID = {zakazivanje.ZakazivanjeId}");

            foreach (VoziloZakazivanje v in zakazivanje.ListaVozilaZakazivanja)
            {
                v.Zakazivanje = zakazivanje;

                if (v.CrudStatus == CrudStatus.Create)
                {
                    repository.Add(v);
                }
                else if (v.CrudStatus == CrudStatus.Delete)
                {
                    repository.Delete(v, $"ZakazivanjeId = {v.Zakazivanje.ZakazivanjeId} AND JMBG = {v.Zakazivanje.Klijent.JMBG}" +
                        $"AND RegistracioniBroj = '{v.Vozilo.RegistracioniBroj}'");
                }
                
            }
          
            


        }
    }
}
