using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    public class Supplier
    {
        public int SupplierId { get; set; }

        public string SupplierName { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }


        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
