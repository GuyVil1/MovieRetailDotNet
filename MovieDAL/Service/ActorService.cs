using ADOLibrary;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DAL.Service
{
    public class ActorService : ServiceBase<int, Actor>
    {

        private Actor Converter(SqlDataReader reader)
        {
            return new Actor(
                (int)reader["Id"],
                reader["Name"].ToString(),
                reader["lastName"].ToString()
                );
        }

        public override IEnumerable<Actor> GetAll()
        {
            Command cmd = new Command("GetAllActor", true);
            return connection.ExecuteReader<Actor>(cmd, Converter);
        }

        public override bool Delete(int key)
        {
            Command cmd = new Command("DeleteActor", true);
            cmd.AddParameter("Id", key);

            return connection.ExecuteNonQuery(cmd) == 1;

        }


        public override Actor GetById(int key)
        {
            Command cmd = new Command("GetActorById", true);
            cmd.AddParameter("Id", id);
            return connection.ExecuteReader<Actor>(cmd, Converter).FirstOrDefault(); 
        }

        public IEnumerable<Actor> GetByFilm(string title)
        {
            Command cmd = new Command("GetAllActorByFilm", true);
            cmd.AddParameter("Title", title);
            return connection.ExecuteReader<Actor>(cmd, Converter);

        }

        public IEnumerable<Actor> GetByInitial(char firstL, char lastL)
        {
            Command cmd = new Command("GetActorByInitial", true);
            cmd.AddParameter("FirstL", firstL);
            cmd.AddParameter("LastL", lastL);

            return connection.ExecuteReader<Actor>(cmd, Converter);
        }

        public IEnumerable<string> GetAllInitials()
        {
            Command cmd = new Command("getAllActorInitial", true);
            return connection.ExecuteReader<Actor>(cmd, Converter);
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
