using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodResort.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FoodResort.Models;


namespace FoodResort.Pages
{
    public class ContentModel : PageModel
    {
        private Context _context;

        [BindProperty]
        public ContentPageModel pageContent { get; set; }

        private NavigationService _navigationService;

        public ContentModel(Context context)
        {
            _context = context;
            pageContent = new ContentPageModel();
        }

        public void OnGet(string pageName)
        {

            Content content = _context.Content.Where(content => content.Title.Equals(pageName)).FirstOrDefault();

            if (content is not null)
            {
                pageContent.Title = content.Title;
                pageContent.Body = content.Body;
            }
            else
            {
                pageContent.Title = "Sorry, this page does not exist (404)";
            }

            
        }
    }
}
