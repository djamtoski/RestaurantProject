using DL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Maps
{
    public class OrderProductMap : EntityTypeConfiguration<OrderProduct>
    {
        public OrderProductMap()
        {
            HasKey(t => new { t.OrderId, t.ProductId });

            Property(t => t.Quantity).IsRequired();

            
        }
    }
}
