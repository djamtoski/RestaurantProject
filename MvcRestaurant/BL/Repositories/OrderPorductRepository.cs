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
    public class OrderPorductRepository : IOrderProductRepository
    {
        private RestaurantContext db;

        public OrderPorductRepository()
        {
            db = new RestaurantContext();
        }

        public void Delete(int id)
        {
            Delete((GetById(id)));
        }

        public void Delete(OrderProduct orderProduct)
        {
            if (orderProduct != null)
            {
                db.OrderProducts.Remove(orderProduct);
                db.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return GetAll().Any(t => t.OrderId == id);
        }

        public IQueryable<OrderProduct> GetAll()
        {
            return db.OrderProducts;
        }

        public OrderProduct GetById(int id)
        {
            return GetAll().Where(t => t.OrderId == id).SingleOrDefault();
        }

        public void Insert(OrderProduct orderProduct)
        {
            if (orderProduct != null)
            {
                db.OrderProducts.Add(orderProduct);
                db.SaveChanges();
            }
        }

        public void Update(OrderProduct orderProduct)
        {
            if (orderProduct != null && Exists(orderProduct.OrderId))
            {
                db.SaveChanges();
            }
        }
    }
}
