using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    public class Stock
    {
        public int StockId { get; set; }

        public int RestaurantId { get; set; }

        public decimal QuantityPerUnit { get; set; }



        public virtual Restaurant Restaurant { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
