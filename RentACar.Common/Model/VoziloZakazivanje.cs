using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Common.Model
{
    [Serializable]
    public class VoziloZakazivanje : IEntity
    {
        public Zakazivanje Zakazivanje { get; set; }
        public Vozilo Vozilo { get; set; }

        [Browsable(false)]
        public string Join => "join Zakazivanje z on VoziloZakazivanje.ZakazivanjeId = z.ZakazivanjeID join Zaposleni za on VoziloZakazivanje.ZaposleniID = za.ZaposleniID join Klijent k on VoziloZakazivanje.JMBG = k.JMBG join Vozilo v on VoziloZakazivanje.RegistracioniBroj = v.RegistracioniBroj";
        [Browsable(false)]
        public string TableName { get => "VoziloZakazivanje"; }
        [Browsable(false)]
        public string InsertValues => $"({Zakazivanje.ZakazivanjeId}, '{Zakazivanje.Klijent.JMBG}', {Zakazivanje.Zaposleni.Id}, '{Vozilo.RegistracioniBroj}')";
        [Browsable(false)]
        public string UpdateValues => "";
        [Browsable(false)]
        public string Output => "inserted.zakazivanjeID";
        [Browsable(false)]
        public CrudStatus CrudStatus { get; set; }


        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> vozilaZakazivanja = new List<IEntity>();  

            while(reader.Read()) { 
            VoziloZakazivanje vz = new VoziloZakazivanje();
                vz.Vozilo = new Vozilo();
                vz.Vozilo.RegistracioniBroj = (string)reader[19];
                vz.Vozilo.MarkaVozila = (string)reader[20];
                vz.Vozilo.MarkaVozila = (string)reader[21];
                vz.Vozilo.Gorivo = (string)reader[22];
                vz.Vozilo.Cena = float.Parse(reader[23].ToString());
                vz.Vozilo.TipVozila = new TipVozila { IDTipVozila = (int)reader[24] };
                vz.Zakazivanje = new Zakazivanje();
                vz.Zakazivanje.ZakazivanjeId = (int)reader[4];
                vz.Zakazivanje.Iznos = float.Parse(reader[7].ToString());
                vz.Zakazivanje.DatumOd = DateTime.Parse(reader[8].ToString());
                vz.Zakazivanje.DatumDo = DateTime.Parse(reader[9].ToString());
                vz.Zakazivanje.Zaposleni = new Zaposleni();
                vz.Zakazivanje.Zaposleni.Id = (int)reader[10];
                vz.Zakazivanje.Zaposleni.Ime = (string)reader[11];
                vz.Zakazivanje.Zaposleni.Prezime = (string)reader[12];
                vz.Zakazivanje.Klijent = new Klijent(); 
                vz.Zakazivanje.Klijent.JMBG = (string)reader[15];
                vz.Zakazivanje.Klijent.Ime = (string)reader[16];
                vz.Zakazivanje.Klijent.Prezime = (string)reader[17];
                vozilaZakazivanja.Add(vz);  
            }

            return vozilaZakazivanja;

        }
    }
}
