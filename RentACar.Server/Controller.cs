using RentACar.Common;
using RentACar.Common.Communication;
using RentACar.Common.Model;
using RentACar.Repository.Implementation;
using RentACar.Repository.Interfaces;
using RentACar.SystemOperations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Server
{
    public class Controller
    {
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        private Controller()
        {
            repository = new GenericDbRepository();
        }
        private IDbRepository<IEntity> repository;



        internal object Login(Zaposleni argument)
        {
            SOPrijavljivanje SOPrijavljivanje = new SOPrijavljivanje();
            SOPrijavljivanje.Zaposleni = argument;
            SOPrijavljivanje.Execute();

            return SOPrijavljivanje.Zaposleni;
        }

        

        internal List<Klijent> VratiKlijente() { 
        
            SystemOperationBase so = new SOVratiKlijente();
            so.Execute();

            return ((SOVratiKlijente) so).Klijenti;
    
        }

        internal List<TipVozila> VratiTipVozila() {

            SystemOperationBase so = new SOVratiTipVozila();
            so.Execute();

            return ((SOVratiTipVozila)so).TipoviVozila;

        }

        internal List<Vozilo> VratiVozila()
        {

            SystemOperationBase so = new SOVratiVozila();
            so.Execute();

            return ((SOVratiVozila)so).Vozila;

        }

        internal Klijent UnosKlijenta(Klijent klijent)
        {

            SOUnosKlijenta sOUnosKlijenta = new SOUnosKlijenta();
            sOUnosKlijenta.k = klijent;
            sOUnosKlijenta.Execute();
            return sOUnosKlijenta.k;


        }

        internal Vozilo UnosVozila(Vozilo vozilo)
        {
            SOUnosVozila so = new SOUnosVozila();
            so.vozilo = vozilo;
            so.Execute();
            return so.vozilo;
        }

        internal List<Klijent> PronadjiKlijente(Klijent k)
        {
            SOPronadjiKlijente so = new SOPronadjiKlijente();
            so.klijent = k;
            so.Execute();

            return so.VraceniKlijenti;
        }

        internal void ZapamtiKlijenta(Klijent klijent)
        {
            SOZapamtiKlijenta so = new SOZapamtiKlijenta();
            so.Klijent = klijent;
            so.Execute();
        }

        internal List<Vozilo> PronadjiVozila(Vozilo v)
        {
            SOPronadjiVozila so = new SOPronadjiVozila();
            so.vozilo = v;
            so.Execute();

            return so.voziloList;
        }

        internal void Obrisi(Vozilo vozilo)
        {
            SOObrisiVozilo so = new SOObrisiVozilo();   
            so.vozilo = vozilo;
            so.Execute();
        }

        internal List<Zakazivanje> VratiZakazivanja()
        {

            SystemOperationBase so = new SOVratiZakazivanja();
            so.Execute();

            return ((SOVratiZakazivanja)so).Zakazivanja;

        }

        public Zakazivanje KreirajZakazivanje(Zakazivanje z)
        {
            SOKreirajZakazivanje so = new SOKreirajZakazivanje();
            so.zakazivanje = z;
            so.Execute();
            return so.zakazivanje;
        }

        internal Klijent UcitajKlijenta(Klijent k)
        {
            SOUcitajKlijenta SOUcitajKlijenta = new SOUcitajKlijenta();
            SOUcitajKlijenta.klijent = k;
            SOUcitajKlijenta.Execute();

            return SOUcitajKlijenta.klijent;
        }

        internal Vozilo UcitajVozilo(Vozilo v)
        {
            SOUcitajVozilo SOUcitajVozilo = new SOUcitajVozilo();
            SOUcitajVozilo.Vozilo = v;
            SOUcitajVozilo.Execute();

            return SOUcitajVozilo.Vozilo;
        }

        public void IzmeniZakazivanje(Zakazivanje z)
        {

            SOIzmeniZakazivanje so = new SOIzmeniZakazivanje();
            so.zakazivanje = z;
            so.Execute();
            
        }

        internal List<Zakazivanje> PronadjiZakazivanja(Zakazivanje z)
        {
            SOPronadjiZakazivanja so = new SOPronadjiZakazivanja();
            so.zakazivanje = z;
            so.Execute();

            return so.listazakazivanja;
        }

        internal Zakazivanje UcitajZakazivanje(Zakazivanje z)
        {
            SOUcitajZakazivanje SOUcitajZakazivanje = new SOUcitajZakazivanje();
            SOUcitajZakazivanje.zakazivanje = z;
            SOUcitajZakazivanje.Execute();

            return SOUcitajZakazivanje.zakazivanje;
        }

    }
}
