using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ExemploAPIDapper.Model;
using Dapper;
using Dapper.Contrib.Extensions;

namespace ExemploAPIDapper.Services
{
    public class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : class
    {
        private SqlConnection sqlCon;
        public Repositorio(string conexao)
        {
            sqlCon = new SqlConnection(conexao);
        }

        public void Add(TEntity entity)
        {
            sqlCon.Insert<TEntity>(entity);
        }

        public void Delete(TEntity entity)
        {
            sqlCon.Delete<TEntity>(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return sqlCon.GetAll<TEntity>();
        }

        public TEntity GetId(int ID)
        {
            return sqlCon.Get<TEntity>(ID);
        }

        public void Update(TEntity entity)
        {
            sqlCon.Update<TEntity>(entity);
        }
    }
}
