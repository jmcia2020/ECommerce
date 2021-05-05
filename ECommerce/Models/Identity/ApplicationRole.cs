using Microsoft.AspNetCore.Identity;
using System;

namespace ECommerce.Models.Identity
{
    public class ApplicationRole : IdentityRole<int>
    {
        public static readonly string Administrator = nameof(Administrator);
        public static readonly string Customer = nameof(Customer);
        DateTime? CreatedAt { get; set; }
    }
}
