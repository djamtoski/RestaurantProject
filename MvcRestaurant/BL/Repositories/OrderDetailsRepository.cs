using DL.Contexts;
using DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Repositories
{
    public class OrderDetailsRepository
    {
        private RestaurantContext db;

        public OrderDetailsRepository()
        {
            db = new RestaurantContext();
        }

        public void Delete(int id)
        {
            Delete((GetById(id)));
        }

        public void Delete(OrderDetails orderDetails)
        {
            if (orderDetails != null)
            {
                db.OrderDetails.Remove(orderDetails);
                db.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return GetAll().Any(t => t.OrderId == id);
        }

        public IQueryable<OrderDetails> GetAll()
        {
            return db.OrderDetails;
        }

        public OrderDetails GetById(int id)
        {
            return GetAll().Where(t => t.OrderId == id).SingleOrDefault();
        }

        public void Insert(OrderDetails orderDetails)
        {
            if (orderDetails != null)
            {
                db.OrderDetails.Add(orderDetails);
                db.SaveChanges();
            }
        }

        public void Update(OrderDetails orderDetails)
        {
            if (orderDetails != null && Exists(orderDetails.OrderId))
            {
                db.SaveChanges();
            }
        }
    }
}
