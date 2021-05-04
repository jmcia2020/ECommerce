using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ECommerce.DbData;
using ECommerce.Models;

namespace ECommerce.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ECommerce.DbData.AppDbContext _context;

        public IndexModel(ECommerce.DbData.AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
