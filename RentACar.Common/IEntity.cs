using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Common
{
    public interface IEntity
    {
        string TableName { get; }
        string InsertValues { get; }

        string UpdateValues { get; }
        string Join { get; }
        string Output { get;}

        List<IEntity> GetList(SqlDataReader reader);
    }
}
