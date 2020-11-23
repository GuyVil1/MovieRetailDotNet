using ADOLibrary;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL.Service
{
    public class ActorService : ServiceBase<int, Actor>
    {
        private Actor Converter(SqlDataReader reader)
        {
            return new Actor(
                (int)reader["ActorId"],
                reader["FirstName"].ToString(),
                reader["lastName"].ToString()
                );
        }
        public override bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Actor> GetAll()
        {
            Command cmd = new Command("GetAllActor", true);
            return Connection.ExecuteReader<Actor>(cmd, Converter);
        }

        public override Actor GetById(int id)
        {
            Command cmd = new Command("GetByIdActor", true);
            cmd.AddParameter("Id", id);
            return Connection.ExecuteReader<Actor>(cmd, Converter).FirstOrDefault();
        }

        public IEnumerable<Actor> GetByFilm(string title)
        {
            Command cmd = new Command("GetAllActorByFilm", true);
            cmd.AddParameter("Title", title);
            return Connection.ExecuteReader<Actor>(cmd, Converter);
        }

        public IEnumerable<Actor> GetByInitial(char first, char last)
        {
            Command cmd = new Command("GetActorByInitial", true);
            cmd.AddParameter("FirstL", first);
            cmd.AddParameter("LastL", last);
            return Connection.ExecuteReader<Actor>(cmd, Converter);
        }

        #region À CORRIGER
        // À Corriger / ! \ ERROR
        public IEnumerable<Actor> GetAllInitials()
        {
            Command cmd = new Command("GetAllActorInitial", true);
            return Connection.ExecuteReader<Actor>(cmd, Converter);

        }
        #endregion

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
