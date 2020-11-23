using ADOLibrary;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Service
{
    public abstract class ServiceBase<Tkey, TEntity> : IService<Tkey, TEntity>
            where TEntity : IEntity<Tkey>
    {
        protected Connection Connection { get; private set; }

        public abstract bool Delete(Tkey key);
        public abstract IEnumerable<TEntity> GetAll();
        public abstract TEntity GetById(Tkey id);
        public abstract Tkey Insert(TEntity entity);
        public abstract bool Update(TEntity entity);

        public ServiceBase()
        {
            Connection = new Connection(@"Data Source=DESKTOP-E4AAE6V;Initial Catalog=MovieRental;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
