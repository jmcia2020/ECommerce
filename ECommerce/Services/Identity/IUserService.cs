using ECommerce.Models.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ECommerce.Services.Identity
{
    public interface IUserService
    {
        Task<ApplicationUser> Register(RegisterData data, string role, ModelStateDictionary modelState);

        Task<bool> SignIn(LoginData data);

        Task<ApplicationUser> GetCurrentUser();
        Task<ApplicationUser> GetUser(ClaimsPrincipal principal);
        Task SetCurrentProfileImageUrl(string url);
    }
}