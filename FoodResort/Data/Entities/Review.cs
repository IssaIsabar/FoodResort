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

    }

}
