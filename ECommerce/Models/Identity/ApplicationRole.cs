using Microsoft.AspNetCore.Identity;
using System;

namespace ECommerce.Models.Identity
{
    public class ApplicationRole : IdentityRole<int>
    {
        DateTime? CreatedAt { get; set; }
    }
}
