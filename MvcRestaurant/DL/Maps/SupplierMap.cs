using DL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Maps
{
    public class SupplierMap : EntityTypeConfiguration<Supplier>
    {
        public SupplierMap()
        {
            HasKey(t => t.SupplierId);

            Property(t => t.SupplierId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(t => t.SupplierName).HasMaxLength(50).IsRequired();
            Property(t => t.City).HasMaxLength(25).IsOptional();
            Property(t => t.Phone).HasMaxLength(25).IsOptional();

            HasMany(w => w.OrderDetails).WithRequired(w => w.Supplier).HasForeignKey(w => w.SupplierId);

        }
    }
}
