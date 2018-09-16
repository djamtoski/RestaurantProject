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
    public class StockRepository : IStockRepository
    {
        private RestaurantContext db;

        public StockRepository()
        {
            db = new RestaurantContext();
        }

        public void Delete(int id)
        {
            Delete((GetById(id)));
        }

        public void Delete(Stock stock)
        {
            if (stock != null)
            {
                db.Stock.Remove(stock);
                db.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return GetAll().Any(t => t.StockId == id);
        }

        public IQueryable<Stock> GetAll()
        {
            return db.Stock;
        }

        public Stock GetById(int id)
        {
            return GetAll().Where(t => t.StockId == id).SingleOrDefault();
        }

        public void Insert(Stock stock)
        {
            if (stock != null)
            {
                db.Stock.Add(stock);
                db.SaveChanges();
            }
        }

        public void Update(Stock stock)
        {
            if (stock != null && Exists(stock.StockId))
            {
                db.SaveChanges();
            }
        }
    }
}
