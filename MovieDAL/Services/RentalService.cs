using ADOLibrairy;
using MovieDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDAL.Services
{
    public class RentalService : ServiceBase<int, Rental>
    {

            

        public override bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Rental> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Rental GetById(int key)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Rental entity)
        {
            Command cmd = new Command("MRSP_CreateRental", true);
            cmd.AddParameter("CustomerId", entity.CustomerId);
            cmd.AddParameter("FilmId", film.Id);
            return 
            
        }

        public override bool Update(Rental entity)
        {
            throw new NotImplementedException();
        }
    }
}
