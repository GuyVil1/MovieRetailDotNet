using ADOLibrairy;
using MovieDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDAL.Services
{
    public abstract class ServiceBase<Tkey, TEntity> : IService<Tkey, TEntity>
        where TEntity : IEntity<Tkey>
    {


        protected Connection connection;

        public ServiceBase()
        {
            this.connection = new Connection(@"Data Source=DESKTOP-E4AAE6V;Initial Catalog=MovieRental;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }


        public abstract bool Delete(Tkey key);

        public abstract IEnumerable<TEntity> GetAll();

        public abstract Tkey Insert(TEntity entity);


        public abstract TEntity GetById(Tkey key);


        public abstract bool Update(TEntity entity);



    }
}
