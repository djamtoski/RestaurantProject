using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    public class OrderProduct
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public decimal Quantity { get; set; }



        public virtual OrderDetails OrderDetails { get; set; }

        public virtual Product Product { get; set; }
    }
}
