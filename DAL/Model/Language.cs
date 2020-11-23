using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Language : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // pour Postman
        public Language()
        {
        }

        public Language(string name)
        {
            Name = name;
        }

        public Language(int id, string name) : this(name)
        {
            Id = id;
        }
    }
}
