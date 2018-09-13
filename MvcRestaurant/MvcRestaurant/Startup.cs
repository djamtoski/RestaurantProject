using BL.Interfaces;
using BL.Repositories;
using DL.AspNetIdentity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcRestaurant.Startup))]
namespace MvcRestaurant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUsers(new RoleManagerRepository(), new UserManagerRepository());
        }

        #region CreateRolesAndUsersMethod
        private void CreateRolesAndUsers(IRoleManagerRepository _roleManagerRepository, IUserManagerRepository _userManagerRepository)
        {
            if (_roleManagerRepository.RoleExists("Admin") == false)
            {
                var role = new IdentityRole("Admin");
                _roleManagerRepository.CreateRole(role);

                var user = new ApplicationUser();
                user.UserName = "sbotev@hotmail.com";
                user.Email = "sbotev@hotmail.com";

                string password = "123456";

                var checkUser = _userManagerRepository.CreateUser(user, password);

                if (checkUser.Succeeded)
                    _userManagerRepository.AddToRole(user.Id, role.Name);
            }

            if (_roleManagerRepository.RoleExists("Owner") == false)
                _roleManagerRepository.CreateRole(new IdentityRole("Owner"));

            if (_roleManagerRepository.RoleExists("Employee") == false)
                _roleManagerRepository.CreateRole(new IdentityRole("Employee"));
        }
        #endregion
    }
}
