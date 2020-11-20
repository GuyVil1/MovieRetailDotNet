using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Rental : IEntity<int>
    {
        public int Id { get; set; }
        public DateTime RentalDate { get; set; }

        public Rental()
        {

        }

        public Rental(int id, DateTime rentalDate) : this(rentalDate)
        {
            Id = id;
        }

        public Rental(DateTime rentalDate)
        {
            RentalDate = rentalDate;
        }
    }
}
