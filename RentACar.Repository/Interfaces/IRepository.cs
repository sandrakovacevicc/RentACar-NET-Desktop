using RentACar.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll(TEntity entity);
        TEntity Get(TEntity entity, string criteria);
        object Add(TEntity entity);
        void Update(TEntity entity, string criteria);

        void Delete(TEntity entity, string criteria);
        List<TEntity> Search(TEntity entity, string criteria);

    }
}
