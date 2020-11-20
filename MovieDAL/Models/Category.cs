﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Category : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set;  }

        public Category() { }

        public Category( string name)
        {
            Name = name;
        }

        public Category(int id, string name) : this(name)
        {
            Id = id;
        }
    }
}
