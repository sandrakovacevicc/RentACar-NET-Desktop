using RentACar.Common;
using RentACar.Repository.DbConnection;
using RentACar.Repository.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Repository.Implementation
{
    public class GenericDbRepository : IDbRepository<IEntity>
    {
        public void Close()
        {
           DbConnectionFactory.Instance.GetDbConnection().Close();
        }

        public void Commit()
        {
            DbConnectionFactory.Instance.GetDbConnection().Commit();
        }

        public void Rollback()
        {
            DbConnectionFactory.Instance.GetDbConnection().Rollback();
        }

        public object Add(IEntity entity)
        {
            string command = $"insert into {entity.TableName} output {entity.Output} values {entity.InsertValues}";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(command);
            return cmd.ExecuteScalar();

        }

        public void Delete(IEntity entity, string criteria)
        {
            string command = $"delete from {entity.TableName}";
            command += $" where {criteria}";

            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(command);
            int x = cmd.ExecuteNonQuery();

            Console.WriteLine("Affected rows update: " + x);

        }

        public List<IEntity> GetAll(IEntity entity)
        {

            string command = $"select * from {entity.TableName}";
            command += " " + entity.Join;

            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(command) ; 
            var reader = cmd.ExecuteReader() ;
            List<IEntity> list = entity.GetList(reader) ;
            reader.Close();

            if(list == null) throw new Exception("Greska");
            return list;
        }

        public IEntity Get(IEntity entity, string criteria)
        {
            string command = $"select * from {entity.TableName} ";
            command += " " + entity.Join;
            command += $" where {criteria}";

            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(command);
            
                var reader = cmd.ExecuteReader();
                
                    List<IEntity> list = entity.GetList(reader);
                    reader.Close();

                    if (list.Count > 0) return list[0];
                    return null;
                
            
        }




        public void Update(IEntity entity, string criteria) {


            string command = $"update {entity.TableName} set {entity.UpdateValues}";

            command += $"where {criteria}";

            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(command);
            int x = cmd.ExecuteNonQuery();

            Console.WriteLine("Affected rows update: " + x);

        }

        public List<IEntity> Search(IEntity entity, string criteria)
        {
            string command = $"select * from {entity.TableName} ";
            command += $"{entity.Join}";
            command += $" where {criteria}";

            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(command);
            var reader = cmd.ExecuteReader();
            List<IEntity> list = entity.GetList(reader);
            reader.Close();

            if (list.Count > 0) return list;
            return null;
        }




    }
}
