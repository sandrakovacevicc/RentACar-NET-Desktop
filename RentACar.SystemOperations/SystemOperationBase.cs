using RentACar.Common;
using RentACar.Repository.Implementation;
using RentACar.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IDbRepository<IEntity> repository;


        public SystemOperationBase()
        {
            repository = new GenericDbRepository();
        }

        public void Execute()
        {
            try
            {
                ExecuteConcreteOperation();
                repository.Commit();
            }
            catch (Exception ex)
            {

               repository.Rollback();
               throw ex;
            }
            finally
            {
                repository.Close();
            }
        }

        protected abstract void ExecuteConcreteOperation();
        
    }
}
