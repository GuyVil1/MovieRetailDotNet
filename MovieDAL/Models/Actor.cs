using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Actor : IEntity<int>
    {

        public int Id { get; set; }

        public string Name { get; set; }


        public Actor()
        {

        }

        public Actor(string name)
        {
            Name = name;
        }

        public Actor(int id, string name) : this(name)
        {
            Id = id;
        }

    }
}
