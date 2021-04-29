using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        // Reverse Navigation (Collection) Property
        public List<Product> Products { get; } = new List<Product>();
    }
}
