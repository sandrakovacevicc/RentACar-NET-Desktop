using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Common.Communication
{
    public enum Operation
    {
        //Zaposleni
        Prijavljivanje,
        Odjavljivanje,
        //Korisnik
        UnosKlijenta,
        PronadjiKlijente,
        UčitajKlijenta,
        ZapamtiKlijenta,
        VratiKlijente,
        //Vozilo
        UnosVozila,
        PronadjiVozila,
        UčitajVozilo,
        ObrišiVozilo,
        VratiVozila,
        //Tip vozila
        VratiTipVozila,
        //Zakazivanje
        KreirajZakazivanje,
        VratiZakazivanje,
        ZapamtiZakazivanje,
        PronadjiZakazivanja,
        UčitajZakazivanje,
       
    }
}
