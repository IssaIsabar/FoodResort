using System;
using System.ComponentModel.DataAnnotations.Schema;
using FoodResort.Data;

namespace FoodResort.Data
{
    public class Review : BaseEntity
    {
        public string Description { get; set; }
        public double Rating { get; set; }

        [ForeignKey("Id")]
        public string UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Id")]
        public Guid PlaceId { get; set; }
        public virtual Place Place { get; set; }

        public Review()
        {
                
        }

        public Review(string desc, double rating, User user, Place place)
        {
            Description = desc;
            Rating = rating;
            User = user;
            UserId = user.Id;
            Place = place;
            PlaceId = new Guid(place.Id);

        }

    }

}
