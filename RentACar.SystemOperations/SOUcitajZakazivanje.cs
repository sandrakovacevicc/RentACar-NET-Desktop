using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.SystemOperations
{
    public class SOUcitajZakazivanje : SystemOperationBase
    {
        public Zakazivanje zakazivanje;

        protected override void ExecuteConcreteOperation()
        {

            zakazivanje = (Zakazivanje)repository.Get(new Zakazivanje(), $"Zakazivanje.ZakazivanjeID ={zakazivanje.ZakazivanjeId}" +
                $" and Zakazivanje.ZaposleniID = {zakazivanje.Zaposleni.Id} and Zakazivanje.JMBG = '{zakazivanje.Klijent.JMBG}'");

            List<VoziloZakazivanje> lista = repository.Search(new VoziloZakazivanje(), $"VoziloZakazivanje.zakazivanjeid = {zakazivanje.ZakazivanjeId} and " +
                $"VoziloZakazivanje.zaposleniid = {zakazivanje.Zaposleni.Id} and VoziloZakazivanje.jmbg = {zakazivanje.Klijent.JMBG}").Cast<VoziloZakazivanje>().ToList();

            zakazivanje.ListaVozilaZakazivanja = lista;

        }
    }
}
