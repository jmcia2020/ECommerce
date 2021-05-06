using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models.Shopping_Cart
{
    public class ShoppingCart
    {
        public int Cart_Id { get; set; }

        public int UserId { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool CheckedOut { get; set; }       
    }
}
