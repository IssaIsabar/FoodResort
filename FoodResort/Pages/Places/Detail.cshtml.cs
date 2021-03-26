using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodResort.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodResort.Pages.Places
{
    public class DetailModel : PageModel
    {
        private readonly Context _context;
        private string _placeId;

        public DetailModel(Context context)
        {
            _context = context;
        }

        public void OnGet(string placeId)
        {
            _placeId = placeId;

            Place place = _context.Places.Where(x => x.Id.Equals(placeId)).FirstOrDefault();

            if (place is not null)
            {
                ViewData["title"] = place.Name;
                ViewData["imgUrl"] = place.ImageUrl;
                ViewData["description"] = place.Description;

            }
            else
            {
                ViewData["title"] = "Sorry";
                ViewData["imgUrl"] = string.Empty;
                ViewData["description"] = "No place found...";
            }

        }


        public async Task<IActionResult> OnPostAddReview(string description, double rating, string placeid)
        {

            User user = _context.Users.Where(x => x.NormalizedUserName.Equals(User.Identity.Name.ToUpper())).FirstOrDefault();

            Place place = _context.Places.Where(x => x.Id == placeid).FirstOrDefault();

            Review review = new Review(description, rating, user, place);

            _context.Review.Add(review);

            _context.SaveChanges();

            Place placex = _context.Places.Where(x => x.Id == placeid).FirstOrDefault();

            if (place is not null)
            {
                ViewData["title"] = placex.Name;
                ViewData["imgUrl"] = placex.ImageUrl;
                ViewData["description"] = placex.Description;

            }

            return Page();
        }

    }
}
