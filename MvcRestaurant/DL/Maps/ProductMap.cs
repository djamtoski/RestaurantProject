using DL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Maps
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            HasKey(w => w.ProductId);

            Property(w => w.ProductId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(w => w.ProductName).HasMaxLength(40).IsRequired();
            Property(w => w.UnitPrice);


            HasMany(w => w.OrderProducts).WithRequired(w => w.Product).HasForeignKey(w => w.ProductId);
            HasRequired(w => w.Stock).WithMany(w => w.Products).HasForeignKey(w => w.StockId);


        }
    }
}
