namespace DL.Contexts
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RestaurantContext : DbContext
    {
        public RestaurantContext() : base(AppConfiguration.ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}