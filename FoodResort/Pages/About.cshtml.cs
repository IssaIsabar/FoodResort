using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodResort.Pages
{
    public class AboutModel : PageModel
    {
        public string Description { get; private set; }


        public void OnGet()
        {
            ViewData["Title"] = "About us";
            ViewData["PageTitle"] = "About us";
            Description = "Lorem ipsum dorom...";
        }

        
    }
}
