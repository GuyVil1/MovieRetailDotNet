using ADOLibrary;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Linq;


namespace DAL.Service
{
    public class FilmService : ServiceBase<int, Film>
    {

        private Film Converter(SqlDataReader reader)
        {
            return new Film(
        (int)reader["Id"],
                reader["Titre"].ToString(),
                reader["Description"].ToString(),
                (int)reader["ReleaseYear"],
                (int)reader["LanguageId"],
                (int)reader["RentalDuration"],
                (decimal)reader["RentalPrice"],
                (int)reader["Length"],
                (decimal)reader["ReplacementCost"],
                (int)reader["RatingId"]
        }

        public override IEnumerable<Film> GetAll()
        {
            Command cmd = new Command("GetAllFilm", true);
            return Connection.ExecuteReader<Film>(cmd, Converter);
        } 

        public IEnumerable<Film> GetByActor(string lastName)
        {
            Command cmd = new Command("GetFilmByActor", true);
            cmd.AddParameter("LastName", lastName);

            return Connection.ExecuteReader<Film>(cmd, Converter);

        }

        public IEnumerable<Film> GetByCategory(string name)
        {
            Command cmd = new Command("GetByCategory", true);
            cmd.AddParameter("Name", name);

            return Connection.ExecuteReader<Film>(cmd, Converter);

        }

        public IEnumerable<Film> GetByLanguage(string language)
        {
            Command cmd = new Command("GetByLanguage", true);
            cmd.AddParameter("Language", language);

            return Connection.ExecuteReader<Film>(cmd, Converter);

        }

        public IEnumerable<Film> GetByTitle(string title)
        {
            Command cmd = new Command("GetByTitle", true);
            cmd.AddParameter("Title", title);

            return Connection.ExecuteReader<Film>(cmd, Converter);
        }

        public IEnumerable<Film> GetByKeyWord(string keyword)
        {
            Command cmd = new Command("GetByKeyWord", true);
            cmd.AddParameter("Keyword", keyword);

            return Connection.ExecuteReader<Film>(cmd, Converter);
        }



        public override bool Delete(int key)
        {
            throw new NotImplementedException();
        }


        public override Film GetById(int id)
        {
            throw new NotImplementedException();
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
