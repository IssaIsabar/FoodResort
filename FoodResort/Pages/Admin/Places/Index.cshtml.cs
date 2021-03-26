using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodResort.Pages.Admin.Places
{
    [Authorize( Roles = "Admin ")]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
