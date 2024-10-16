using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Repository.DbConnection
{
    public class DbConnection
    {
        SqlConnection _connection;
        SqlTransaction _transaction;


        public void OpenConnection()
        {
            if (!IsReady())
            {
                _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["RentACar"].ConnectionString);
                _connection.Open();
            }
        }

        public SqlCommand CreateCommand(string sql = "") {
        
            if(_transaction?.Connection == null)
                _transaction = _connection.BeginTransaction();
            return new SqlCommand(sql, _connection, _transaction);
        }

        public void Commit()
        {
            _transaction?.Commit();
        }

        public void Rollback()
        {
            _transaction?.Rollback();
        }

        public bool IsReady()
        {
            return _connection != null && _connection.State!= ConnectionState.Closed;
        }

        public void Close()
        {
            _connection?.Close();
            _transaction?.Dispose();
            _transaction = null;
        }
    }
}
