using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Rental : IEntity<int>
    {
        public int Id { get; set; }
        public DateTime RentalDate { get; set; }
        public int CustomerId { get; set; }

        public Rental()
        {
        }

        public Rental(DateTime rentalDate, int customerId)
        {
            RentalDate = rentalDate;
            CustomerId = customerId;
        }

        public Rental(int id, DateTime rentalDate, int customerId) : this(rentalDate, customerId)
        {
            Id = id;
        }
    }
}
