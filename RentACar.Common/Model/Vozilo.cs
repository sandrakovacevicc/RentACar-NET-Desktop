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
    public class Vozilo : IEntity
    {
        public string RegistracioniBroj { get; set; }
        public string MarkaVozila { get; set; }
        public string ModelVozila { get; set; }
        public string Gorivo { get; set; }
        public float Cena { get; set; }
        [Browsable(false)]

        public TipVozila TipVozila { get; set; }

        [Browsable(false)]
        public string TableName { get => "Vozilo"; }

        [Browsable(false)]
        public string InsertValues => $"('{RegistracioniBroj}', '{MarkaVozila}', '{ModelVozila}', '{Gorivo}', {Cena}, {TipVozila.IDTipVozila})";
        [Browsable(false)]
        public string Join => "join TipVozila tv on Vozilo.TipVozilaId = tv.TipVozilaID";
        [Browsable(false)]
        public string UpdateValues => "";
        [Browsable(false)]
        public string SearchQuery { get; set; }

        [Browsable(false)]
        public string Output => "inserted.RegistracioniBroj";
        [Browsable(false)]
        public CrudStatus CrudStatus { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Vozilo vozilo &&
                   RegistracioniBroj == vozilo.RegistracioniBroj;
        }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> vozila = new List<IEntity>();

            while (reader.Read())
            {
                Vozilo v = new Vozilo();
                v.RegistracioniBroj = (string)reader[0];
                v.MarkaVozila = (string)reader[1];
                v.ModelVozila = (string)reader[2];
                v.Gorivo = (string)reader[3];
                v.Cena = float.Parse(reader[4].ToString());
                v.TipVozila = new TipVozila { IDTipVozila = (int)reader[5], Naziv = (string)reader[7] };

                vozila.Add(v);
            }
            return vozila;
        }

        public override string ToString()
        {
            return RegistracioniBroj  + " " + MarkaVozila + " " + ModelVozila + " " + Gorivo + " " + Cena  +" " + TipVozila.Naziv;
        }
    }
}
