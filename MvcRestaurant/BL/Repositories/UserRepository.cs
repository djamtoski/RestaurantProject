using BL.Interfaces;
using DL.Contexts;
using DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private RestaurantContext db;

        public UserRepository()
        {
            db = new RestaurantContext();
        }

        public void Delete(int id)
        {
            Delete((GetById(id)));
        }

        public void Delete(User user)
        {
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return GetAll().Any(t => t.UserId == id);
        }

        public IQueryable<User> GetAll()
        {
            return db.Users;
        }

        public User GetById(int id)
        {
            return GetAll().Where(t => t.UserId == id).SingleOrDefault();
        }

        public void Insert(User user)
        {
            if (user != null)
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public void Update(User user)
        {
            if (user != null && Exists(user.UserId))
            {
                db.SaveChanges();
            }
        }
    }
}
