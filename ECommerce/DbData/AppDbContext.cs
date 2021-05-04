using ECommerce.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ECommerce.Models;

namespace ECommerce.DbData
{
    public class AppDbContext :
        IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ECommerce.Models.Product> Product { get; set; }
    }
}
