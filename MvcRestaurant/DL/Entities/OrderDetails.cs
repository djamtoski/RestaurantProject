using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    public class OrderDetails
    {
        public int OrderId { get; set; }

        public int SupplierId { get; set; }  



        public virtual Supplier Supplier { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

    }
}
