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
    public class Zakazivanje : IEntity
    {
        [Browsable(false)]
        public int ZakazivanjeId { get; set; }
        public Zaposleni Zaposleni { get; set; }
        public Klijent Klijent { get; set; }
        [Browsable(false)]
        public List<VoziloZakazivanje> ListaVozilaZakazivanja {  get; set; }
        public float Iznos { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        [Browsable(false)]
        public string Join => "join Zaposleni zaposleni on Zakazivanje.ZaposleniID = zaposleni.ZaposleniID  join Klijent klijent on Zakazivanje.JMBG = klijent.JMBG ";
        [Browsable(false)]
        public string TableName { get => "Zakazivanje"; }
        [Browsable(false)]
        public string InsertValues => $"({Zaposleni.Id}, '{Klijent.JMBG}', {Iznos}, '{DatumOd}', '{DatumDo}')";
        [Browsable(false)]
        public string UpdateValues => $"Iznos = '{Iznos}', DatumOd = '{DatumOd}', DatumDo = '{DatumDo}'";
        [Browsable(false)]
        public string Output => "inserted.ZakazivanjeID";
        [Browsable(false)]
        public CrudStatus CrudStatus { get; set; }
        [Browsable(false)]
        public string SearchQuery { get; set; }


        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> zakazivanja = new List<IEntity>();
            while (reader.Read())
            {
                Zakazivanje z = new Zakazivanje();
                z.ZakazivanjeId = (int)reader[0];
                z.Zaposleni = new Zaposleni()
                {
                    Id = (int)reader[6],
                    Ime = (string)reader[7],
                    KorisnickoIme = (string)reader[9],
                    Lozinka = (string)reader[10]

                };
                z.Klijent = new Klijent();
                z.Klijent.JMBG = (string)reader[11];
                z.Klijent.Ime = (string)reader[12];
                z.Klijent.Prezime = (string)reader[13];
                z.Klijent.Email = (string)reader[14];
                z.Iznos = Convert.ToSingle(reader[3]);
                z.DatumOd = (DateTime)reader[4];
                z.DatumDo = (DateTime)reader[5];
              
              
                

                zakazivanja.Add(z);
              
            }
            return zakazivanja;
        }
        public override string ToString()
        {
            return $"{Zaposleni.Ime} {Klijent.Ime} {Iznos}";
        }
    }
}
