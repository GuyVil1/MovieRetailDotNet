using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Service
{
    interface IService<TKey, TEntity>
        where TEntity : IEntity<TKey>
    {
        //CREATE
        TKey Insert(TEntity entity);

        // READ
        TEntity GetById(TKey key);
        IEnumerable<TEntity> GetAll();

        // Update
        bool Update(TEntity entity);

        // Delete
        bool Delete(TKey key);

    }
}
