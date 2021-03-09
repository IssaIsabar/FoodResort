using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodResort.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodResort.Pages
{
    public class RestaurantsModel : PageModel
    {
        [BindProperty]
        public List<Place> Places { get; set; }

        private Context _context;

        public RestaurantsModel(Context context)
        {
            _context = context;
        }

        public void OnGet(string searchQuery)
        {
            if (string.IsNullOrEmpty(searchQuery))
            {

                Places = _context.Places.ToList();
            }
            else
            {
                Places = _context.Places.Where(x => x.Name.Contains(searchQuery) || x.Description.Contains(searchQuery)).ToList();
            }

        }
    }
}
