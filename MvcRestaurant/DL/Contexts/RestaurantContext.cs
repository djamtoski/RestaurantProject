namespace DL.Contexts
{
    using DL.Entities;
    using DL.Maps;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RestaurantContext : DbContext
    {
        public RestaurantContext() : base(AppConfiguration.ConnectionString)
        {

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OrderDetailsMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new RestaurantMap());
            modelBuilder.Configurations.Add(new StockMap());
            modelBuilder.Configurations.Add(new SupplierMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new OrderProductMap());
        }
    }
}