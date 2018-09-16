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
    public class ProductRepository : IProductRepository
    {
        private RestaurantContext db;

        public ProductRepository()
        {
            db = new RestaurantContext();
        }

        public void Delete(int id)
        {
            Delete((GetById(id)));
        }

        public void Delete(Product product)
        {
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return GetAll().Any(t => t.ProductId == id);
        }

        public IQueryable<Product> GetAll()
        {
            return db.Products;
        }

        public Product GetById(int id)
        {
            return GetAll().Where(t => t.ProductId == id).SingleOrDefault();
        }

        public void Insert(Product product)
        {
            if (product != null)
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            if (product != null && Exists(product.ProductId))
            {
                db.SaveChanges();
            }
        }
    }
}
