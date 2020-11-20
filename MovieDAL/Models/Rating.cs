using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Rating : IEntity<int>
    {
        public Rating()
        {

        }
        public Rating(int id, string classement) : this(classement)
        {
            Id = id;
        }

        public Rating(string classement)
        {
            Classement = classement;
        }

        public int Id { get; set; }
        public string Classement { get; set; }


    }
}
