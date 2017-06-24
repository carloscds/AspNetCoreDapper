using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploAPIDapper.Services
{
    public interface IRepositorio<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        TEntity GetId(int ID);
        IEnumerable<TEntity> GetAll();
    }
}
