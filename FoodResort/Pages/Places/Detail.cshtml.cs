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

        public DetailModel(Context context)
        {
            _context = context;
        }

        public void OnGet(string placeId)
        {
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
    }
}
