using DL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Maps
{
    public class StockMap : EntityTypeConfiguration<Stock>
    {
        public StockMap()
        {
            HasKey(t => t.StockId);
            Property(t => t.StockId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(t => t.QuantityPerUnit).IsRequired();
            Property(t => t.RestaurantId).IsRequired();

            HasRequired(t => t.Restaurant).WithOptional(t=>t.Stock);
        }

    }
}
