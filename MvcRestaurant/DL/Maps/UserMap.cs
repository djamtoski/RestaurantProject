using DL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Maps
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(t => t.UserId);

            Property(t => t.UserId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(t => t.AspNetUserId).HasMaxLength(128).IsRequired();
            Property(t => t.UserName).HasMaxLength(256).IsRequired();
            Property(t => t.Email).HasMaxLength(256).IsOptional();
            Property(t => t.FirstName).HasMaxLength(128).IsOptional();
            Property(t => t.LastName).HasMaxLength(128).IsOptional();
            Property(t => t.BirthDate).IsOptional();
        }
    }
}
