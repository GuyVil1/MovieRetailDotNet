using ADOLibrary;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;



namespace DAL.Service
{
    public class ActorService : ServiceBase<int, Actor>
    {

        private Actor Converter(SqlDataReader reader)
        {
            return new Actor(
                (int)reader["Id"],
                reader["Name"].ToString()
                );

        }
        public override bool Delete(int key)
        {
            Command cmd = new Command("DeleteActor", true);
            cmd.AddParameter("Id", key);

            return connection.ExecuteNonQuery(cmd) == 1;
            

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
