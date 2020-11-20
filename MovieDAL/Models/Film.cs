using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public int LangugaeId { get; set;  }
        public int RentalDuration { get; set; }
        public decimal RentalPrice { get; set;  }
        public int Lenght { get; set; }

        public decimal RemplacementCost { get; set; }
        public int RatingId { get; set; }

        public Film()
        {

        }

        public Film(string title, string description, int releaseYear, int langugaeId, int rentalDuration, decimal rentalPrice, int lenght, decimal remplacementCost, int ratingId)
        {
            Title = title;
            Description = description;
            ReleaseYear = releaseYear;
            LangugaeId = langugaeId;
            RentalDuration = rentalDuration;
            RentalPrice = rentalPrice;
            Lenght = lenght;
            RemplacementCost = remplacementCost;
            RatingId = ratingId;
        }

        public Film(int id, string title, string description, int releaseYear, int langugaeId, int rentalDuration, decimal rentalPrice, int lenght, decimal remplacementCost, int ratingId) : this(title, description, releaseYear ,langugaeId, rentalDuration, rentalPrice, lenght, remplacementCost, ratingId)
        {
            Id = id;
        }
    }
}