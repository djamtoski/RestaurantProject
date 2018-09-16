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
    public class SupplierRepository : ISupplierRepository
    {
        private RestaurantContext db;

        public SupplierRepository()
        {
            db = new RestaurantContext();
        }

        public void Delete(int id)
        {
            Delete((GetById(id)));
        }

        public void Delete(Supplier supplier)
        {
            if (supplier != null)
            {
                db.Suppliers.Remove(supplier);
                db.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return GetAll().Any(t => t.SupplierId == id);
        }

        public IQueryable<Supplier> GetAll()
        {
            return db.Suppliers;
        }

        public Supplier GetById(int id)
        {
            return GetAll().Where(t => t.SupplierId == id).SingleOrDefault();
        }

        public void Insert(Supplier supplier)
        {
            if (supplier != null)
            {
                db.Suppliers.Add(supplier);
                db.SaveChanges();
            }
        }

        public void Update(Supplier supplier)
        {
            if(supplier != null && Exists(supplier.SupplierId))
            {
                db.SaveChanges();
            }
        }
    }
}
