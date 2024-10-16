using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RentACar.Common.Model
{
    [Serializable]
    public class Klijent : IEntity
    {
        public string JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }

        [Browsable(false)]
        public string TableName { get => "Klijent"; }

        [Browsable(false)]
        public string InsertValues => $"('{JMBG}', '{Ime}','{Prezime}', '{Email}')";

        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string SearchQuery { get; set; }
        [Browsable(false)]
        public string UpdateValues => $"JMBG = '{JMBG}', Ime = '{Ime}', Prezime = '{Prezime}', [E-mail] = '{Email}'";
        [Browsable(false)]
        public string Output => "inserted.JMBG";
        [Browsable(false)]
        public CrudStatus CrudStatus { get; set; }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> klijenti = new List<IEntity>();
            while (reader.Read())
            {
                Klijent k = new Klijent();
                k.JMBG = (string)reader[0];
                k.Ime = (string)reader[1];
                k.Prezime = (string)reader[2];
                k.Email = (string)reader[3];
                

                klijenti.Add(k);
            }
            return klijenti;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
