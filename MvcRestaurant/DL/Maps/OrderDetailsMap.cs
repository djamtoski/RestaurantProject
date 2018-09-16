using DL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Maps
{
    public class OrderDetailsMap : EntityTypeConfiguration<OrderDetails>
    {
        public OrderDetailsMap()
        {
            HasKey(t => t.OrderId);

            Property(t => t.OrderId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            HasMany(w => w.OrderProducts).WithRequired(w => w.OrderDetails).HasForeignKey(w => w.OrderId);

        }
    }
}
