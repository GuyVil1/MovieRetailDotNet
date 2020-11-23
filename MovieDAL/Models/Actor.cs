using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Actor : IEntity<int>
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }


        public Actor()
        {

        }

        public Actor(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public Actor(int id, string name, string lastName) : this(name, lastName)
        {
            Id = id;
        }

    }
}
