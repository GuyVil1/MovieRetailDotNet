using ADOLibrary;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL.Service
{
    public class FilmService : ServiceBase<int, Film>
    {
        private Film Converter(SqlDataReader reader)
        {
            return new Film(
                (int)reader["FilmId"],
                reader["Title"].ToString(),
                reader["Description"].ToString(),
                (int)reader["ReleaseYear"],
                (int)reader["LanguageId"],
                (int)reader["RentalDuration"],
                (decimal)reader["RentalPrice"],
                (int)reader["Length"],
                (decimal)reader["ReplacementCost"],
                (int)reader["RatingId"]
                );
        }

        public IEnumerable<Film> GetByActor(int id) {
            Command cmd = new Command("GetFilmByActor", true);
            cmd.AddParameter("ActorId", id);
            return Connection.ExecuteReader<Film>(cmd, Converter);
        }

        public IEnumerable<Film> GetByCategory(int id)
        {
            Command cmd = new Command("GetFilmByCategory", true);
            cmd.AddParameter("CategoryId", id);
            return Connection.ExecuteReader<Film>(cmd, Converter);
        }

        public IEnumerable<Film> GetByLanguage(int id)
        {
            Command cmd = new Command("GetFilmByLanguage", true);
            cmd.AddParameter("LanguageId", id);
            return Connection.ExecuteReader<Film>(cmd, Converter);
        }

        public IEnumerable<Film> GetByTitle(string title)
        {
            Command cmd = new Command("GetFilmByTitle", true);
            cmd.AddParameter("Title", title);
            return Connection.ExecuteReader<Film>(cmd, Converter);
        }

        public IEnumerable<Film> GetByKeyWord(string keyWord)
        {
            Command cmd = new Command("GetFilmByKeyWord", true);
            cmd.AddParameter("KeyWord", keyWord);
            return Connection.ExecuteReader<Film>(cmd, Converter);
        }

        public override bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Film> GetAll()
        {
            Command cmd = new Command("GetAllFilm", true);
            return Connection.ExecuteReader<Film>(cmd, Converter);
        }

        public override Film GetById(int id)
        {
            Command cmd = new Command("GetFilmById", true);
            cmd.AddParameter("Id", id);
            return Connection.ExecuteReader<Film>(cmd, Converter).FirstOrDefault();

        }

        public override int Insert(Film entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Film entity)
        {
            throw new NotImplementedException();
        }
    }
}
