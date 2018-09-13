using DL.AspNetIdentity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BL.Interfaces
{
    public interface IUserManagerRepository
    {
        IdentityResult CreateUser(ApplicationUser user, string password);
        IdentityResult AddToRole(string userId, string roleName);
    }
}
