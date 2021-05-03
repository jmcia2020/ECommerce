using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models.Identity
{
    public class LoginData
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
