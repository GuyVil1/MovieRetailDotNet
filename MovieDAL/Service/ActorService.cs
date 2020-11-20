using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Service
{
    public class ActorService : ServiceBase<int, Actor>
    {
        public override bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Actor> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Actor GetById(int key)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Actor entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Actor entity)
        {
            throw new NotImplementedException();
        }
    }
}
