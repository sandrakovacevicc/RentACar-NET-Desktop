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
    public class Zaposleni : IEntity
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string TableName { get => "Zaposleni"; }
        public string InsertValues => $"'{Ime}', '{Prezime}', {KorisnickoIme}, {Lozinka}";

        public string Join => "";

        public string UpdateValues => "";
        public string Output => "";

        [Browsable(false)]
        public CrudStatus CrudStatus { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Zaposleni zaposleni &&
                   Ime == zaposleni.Ime &&
                   Prezime == zaposleni.Prezime &&
                   KorisnickoIme == zaposleni.KorisnickoIme &&
                   Lozinka == zaposleni.Lozinka;
        }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> zaposleni = new List<IEntity>();
            while (reader.Read())
            {
                Zaposleni z = new Zaposleni();
                z.Id = (int)reader[0];
                z.Ime = (string)reader[1];
                z.Prezime = (string)reader[2];
                z.KorisnickoIme = (string)reader[3];
                z.Lozinka = (string)reader[4];

                zaposleni.Add(z);
            }
            return zaposleni;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

    }
}
