using ADOLibrary;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Service
{
    public abstract class ServiceBase<TKey, TEntity> : IService<TKey, TEntity>
        where TEntity : IEntity<TKey>
    {
        protected Connection connection { get; set; }

        public ServiceBase()
        {
            connection = new Connection(@"Data Source=LAPTOP-P7APKIUO;Initial Catalog=DBBeer;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public abstract bool Delete(TKey key);
        public abstract IEnumerable<TEntity> GetAll();
        public abstract TEntity GetById(TKey key);
        public abstract TKey Insert(TEntity entity);
        public abstract bool Update(TEntity entity);
    }
}
