using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FoodResort.Data
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public string ProfilePhotoUrl { get; set; }
        public bool IsVerified { get; set; }

        public virtual List<Review> Reviews { get; set; }
    }

}
