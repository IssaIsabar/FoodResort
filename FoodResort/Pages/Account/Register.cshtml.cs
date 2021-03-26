using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FoodResort.Data;
using FoodResort.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodResort.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private UserManager<User> _userManager;

        private SignInManager<User> _signInManager;

        private Context _context;

        [BindProperty]
        public RegisterPageModel pageModel { get; set; }

        public RegisterModel(UserManager<User> userManager, SignInManager<User> signInManager, Context context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostRegister()
        {

            if (!string.IsNullOrWhiteSpace(pageModel.Username) && !string.IsNullOrWhiteSpace(pageModel.Email) && !string.IsNullOrWhiteSpace(pageModel.Password))
            {

                User user = new User()
                {
                    UserName = pageModel.Username,
                    Email = pageModel.Email
                };

                var result = await _userManager.CreateAsync(user, pageModel.Password);

                if (result.Succeeded)
                {

                    if (_context.Users.Count() == 1)
                    {
                        await _userManager.AddToRoleAsync(user, "Admin");
                    }
                    else
                    {
                        await _userManager.AddToRoleAsync(user, "User");
                    }

                    var signIn = await _signInManager.PasswordSignInAsync(user, pageModel.Password, pageModel.RememeberMe, false);

                    if (signIn.Succeeded)
                    {
                        return LocalRedirect("/");

                    }
                }
            }
            else
            {
                ViewData["message"] = "Your model is not valid, you seem to be missing something";
            }

            return Page();

        }
    }

}
