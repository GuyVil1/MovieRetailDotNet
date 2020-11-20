using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Actor : IEntity<int>
    {

        public int Id { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string Email { get; set; }

        public string Passwd { get; set; }



        public Actor()
        {

        }

        public Actor(string lastName, string firstName, string email, string passwd)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            Passwd = passwd;
        }

        public Actor(int id, string lastName, string firstName, string email, string passwd) : this(lastName, firstName, email, passwd)
        {
            Id = id;

        }

    }
}
