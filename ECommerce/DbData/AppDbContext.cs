using ECommerce.Models;
using ECommerce.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DbData
{
    public class AppDbContext :
        IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Keep this so Identity still works!
            base.OnModelCreating(builder);

            builder.Entity<Product>()
                .HasData(
                new Product
                {
                    Id = 1,
                    Name = "Easter Pillow Cover",
                    Description = "Burlap 18 X 18 pillow cover with Easter motif",
                    Price = 25.25m,
                    OnSale = true,
                },
                new Product
                {
                    Id = 2,
                    Name = "Summer Pillow Cover",
                    Description = "Burlap 18 X 18 pillow cover with Summer Flowers motif",
                    Price = 15.75m,
                    OnSale = true,
                },

                new Product
                {
                    Id = 3,
                    Name = "Throw Blanket",
                    Description = "Yellow 100% Cotton 50\" x 60\" throw blanket",
                    Price = 19.75m,
                },

                new Product
                {
                    Id = 4,
                    Name = "Down Alternative Bed Pillow",
                    Description = "Standard size machine washable medium firm down alternative pillow",
                    Price = 25.43m,
                });
        } 

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

    }
}

