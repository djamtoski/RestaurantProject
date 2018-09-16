using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        public int StockId { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }



        public virtual Stock Stock { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

    }
}
