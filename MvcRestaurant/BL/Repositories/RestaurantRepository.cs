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
    public class RestaurantRepository : IRestaurantRepository
    {
        private RestaurantContext db;

        public RestaurantRepository()
        {
            db = new RestaurantContext();
        }

        public void Delete(int id)
        {
            Delete((GetById(id)));
        }

        public void Delete(Restaurant restaurant)
        {
            if (restaurant != null)
            {
                db.Restaurants.Remove(restaurant);
                db.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return GetAll().Any(t => t.RestaurantId == id);
        }

        public IQueryable<Restaurant> GetAll()
        {
            return db.Restaurants;
        }

        public Restaurant GetById(int id)
        {
            return GetAll().Where(t => t.RestaurantId == id).SingleOrDefault();
        }

        public void Insert(Restaurant restaurant)
        {
            if (restaurant != null)
            {
                db.Restaurants.Add(restaurant);
                db.SaveChanges();
            }
        }

        public void Update(Restaurant restaurant)
        {
            if (restaurant != null && Exists(restaurant.RestaurantId))
            {
                db.SaveChanges();
            }
        }
    }
}
