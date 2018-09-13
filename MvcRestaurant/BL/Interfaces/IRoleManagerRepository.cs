using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BL.Interfaces
{
    public interface IRoleManagerRepository
    {
        IdentityResult CreateRole(IdentityRole role);
        bool RoleExists(string roleName);
    }
}
