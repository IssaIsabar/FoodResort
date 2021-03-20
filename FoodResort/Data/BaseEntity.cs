using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodResort.Data
{
    public class BaseEntity
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public DateTime Created { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
            Created = DateTime.Now;
        }
    }
}
