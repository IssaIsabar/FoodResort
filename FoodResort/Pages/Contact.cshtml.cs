using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodResort.Pages
{
    
    public class ContactModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public Contact Contact { get; set; }

        public bool MessageSent { get; set; }

        public ContactModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        

        public void OnGet()
        {

            MessageSent = false;
        }

        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (IsEmailValid(Contact.Email))
            {

                MessageSent = true;
                ViewData["ResultMessage"] = " Message was sent";
            }
            else
            {
                MessageSent = false;
                ViewData["ResultMessage"] = "Something went wrong";
            }

            return null;
        }




        public static bool IsEmailValid(string value)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(value);
                return true;
            }
            catch
            {
                return false;
            }
        }


    }

    
    public class Contact
    {
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
    }
}
