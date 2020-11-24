using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Customer : IEntity<int>
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Passwd { get; set; }

        public string Token { get; set; }

        // pour Postman
        public Customer()
        {
        }

        public Customer(string lastName, string firstName, string email, string passwd, string token)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            Passwd = passwd;
            Token = token;
        }

        public Customer(int id, string lastName, string firstName, string email, string passwd, string token) : this(lastName, firstName, email, passwd, token)
        {
            Id = id;
        }
    }
}
