using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class Product
    {
        [StringLength(250)]
        public string ProdImageUrl { get; set; }
        
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool OnSale { get; set; }


        // Foreign Key
        // Nullable so it's not required
        public int? Category_Id { get; set; }

        // Navigation Property
        public Category Category { get; set; }
    }
}
