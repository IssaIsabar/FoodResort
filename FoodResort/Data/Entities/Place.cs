using System.Collections.Generic;
using FoodResort.Data;

namespace FoodResort.Data
{
    public class Place : BaseEntity
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public double Rating { get; set; }

        public virtual List<Review> Reviews { get; set; }
    }

}
