using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Customer : IEntity<int>
    {
        public Customer(string lastName, string firstName, string email, string passwd)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            Passwd = passwd;
        }

        public Customer(int id, string lastName, string firstName, string email, string passwd) : this(lastName, firstName, email, passwd)
        {
            Id = id;
        }

        public Customer()
        {

        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Passwd {private get; set; }
    }

}
