using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodResort.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodResort.Pages.Account
{
    public class LoginModel : PageModel
    {

        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;

        public LoginModel(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;

            _signInManager = signInManager;
        }

        public void OnGet(string value)
        {
            if (value is not null)
            {
                if(value.Equals("accessdenied"))
                {
                    ViewData["message"] = "You dont have access to that page, please sign in with the correct account.";
                }
                
            }
        }

        public async Task<IActionResult> OnPostLogin(string user, string password, bool rememberMe)
        {

            if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(password))
            {

                User usr = user.Contains("@") ? await _userManager.FindByEmailAsync(user) : await _userManager.FindByNameAsync(user);

                if (usr is not null)
                {
                    try
                    {
                        var result = await _signInManager.PasswordSignInAsync(usr, password, rememberMe, false);

                        if (result.Succeeded)
                        {
                            return LocalRedirect("/");
                        }
                        else
                        {
                            ViewData["message"] = "Login failed, check your password";
                        }
                    }
                    catch(Exception ex)        
                    {
                        ViewData["message"] = $"Something went wrong: {ex}";
                    }
                    
                }
                else
                {
                    ViewData["message"] = "User does not exist";
                }

            }
            else
            {
                ViewData["message"] = "You must enter a username and password";
            }

            return Page();
        }
    }
}
