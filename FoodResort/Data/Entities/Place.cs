using System.Collections.Generic;
using FoodResort.Data;

namespace FoodResort.Data
{
    public class Place : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public double Rating { get; set; }

        public virtual List<Review> Reviews { get; set; }

        public Place()
        {
            Name = string.Empty;
            Description = string.Empty;
            ImageUrl = string.Empty;
            Street = string.Empty;
            City = string.Empty;
            ZipCode = string.Empty;
            Rating = 0.0;
            Reviews = new List<Review>();
        }

        public Place(string name, string description, string imageUrl)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;

            Street = string.Empty;
            City = string.Empty;
            ZipCode = string.Empty;
            Rating = 0.0;
            Reviews = new List<Review>();
        }
    }

}
