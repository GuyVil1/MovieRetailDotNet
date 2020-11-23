using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Service
{
    interface IService<Tkey, TEntity>
         where TEntity: IEntity<Tkey>
    {
        // Create
        Tkey Insert(TEntity entity);

        // Read
        TEntity GetById(Tkey id);
        IEnumerable<TEntity> GetAll();

        // Update
        bool Update(TEntity entity);

        // Delete
        bool Delete(Tkey key);
    }
}
