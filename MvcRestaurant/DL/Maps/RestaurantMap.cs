using DL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Maps
{
    public class RestaurantMap : EntityTypeConfiguration<Restaurant>
    {
        public RestaurantMap()
        {
            HasKey(t => t.RestaurantId);

            Property(t => t.RestaurantId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(t => t.UserId).IsRequired();
            Property(t => t.Name).HasMaxLength(100).IsRequired();
            Property(t => t.Description).HasMaxLength(500);

            HasRequired(t => t.User).WithMany(t => t.Restaurants).HasForeignKey(t => t.UserId);
        }
    }
}
