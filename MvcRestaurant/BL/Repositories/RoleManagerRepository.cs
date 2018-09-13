using BL.Interfaces;
using DL.Contexts;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Repositories
{
    public class RoleManagerRepository : IRoleManagerRepository
    {
        private ApplicationDbContext context;
        private RoleManager<IdentityRole> roleManager;

        public RoleManagerRepository()
        {
            context = new ApplicationDbContext();
            roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
        }

        public IdentityResult CreateRole(IdentityRole role)
        {
            return roleManager.Create(role);
        }

        public bool RoleExists(string roleName)
        {
            return roleManager.RoleExists(roleName);
        }
    }
}
