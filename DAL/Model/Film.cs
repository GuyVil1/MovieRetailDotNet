﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Film : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public int LanguageId { get; set; }
        public int RentalDuration { get; set; }
        public decimal RentalPrice { get; set; }
        public int Lenght { get; set; }
        public decimal ReplacementCost { get; set; }
        public int RatingId { get; set; }

        // pour Postman
        public Film()
        {
        }

        public Film(string title, string description, int releaseYear, int languageId, int rentalDuration, decimal rentalPrice, int lenght, decimal replacementCost, int ratingId)
        {
            Title = title;
            Description = description;
            ReleaseYear = releaseYear;
            LanguageId = languageId;
            RentalDuration = rentalDuration;
            RentalPrice = rentalPrice;
            Lenght = lenght;
            ReplacementCost = replacementCost;
            RatingId = ratingId;
        }

        public Film(int id, string title, string description, int releaseYear, int languageId, int rentalDuration, decimal rentalPrice, int lenght, decimal replacementCost, int ratingId)
            : this(title, description, releaseYear, languageId, rentalDuration, rentalPrice, lenght, replacementCost, ratingId)
        {
            Id = id;
        }
    }
}