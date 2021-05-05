using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerce.Pages
{
    public class ShoppingCartModel : PageModel
    {
        public IActionResult OnGet()
        {
            return NotFound();  
        }

        public async Task<IActionResult> OnPost()
        {
            //ProductList?
            return Redirect("/");
        }
    }
}
