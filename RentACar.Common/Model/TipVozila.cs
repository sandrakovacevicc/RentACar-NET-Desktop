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
    public class TipVozila : IEntity
    {
        public int IDTipVozila { get; set; }
        public string Naziv { get; set; }

        public string TableName { get => "TipVozila"; }
        public string Join => "";
        public string InsertValues => $"({IDTipVozila}, '{Naziv}')";

        public string UpdateValues => "";
        public string Output => "";
        [Browsable(false)]
        public CrudStatus CrudStatus { get; set; }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> tipoviVozila = new List<IEntity>();
            while (reader.Read())
            {
                TipVozila tip = new TipVozila();
                tip.IDTipVozila = (int)reader[0];
                tip.Naziv = (string)reader[1];
                
                tipoviVozila.Add(tip);
            }
            return tipoviVozila;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
