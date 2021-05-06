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
        public async Task<IActionResult> OnPost()
        {
            
            return Redirect("/AddToCart");
        }

        public IActionResult OnGet()
        {
            //ProductDetailList?
            return Redirect("/GetMyCart");
        }
    }
}
