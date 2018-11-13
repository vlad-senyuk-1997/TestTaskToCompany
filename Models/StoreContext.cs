using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestTask.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }

        static StoreContext()
        {
            Database.SetInitializer<StoreContext>(new StoreInitializer());
        }
    }

    public class StoreInitializer : DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext db)
        {
            db.Stores.Add(new Store { Name = "Apple Store", Location = "USA", Mode = "9:00-6:00", Id = 1 });
            db.Stores.Add(new Store { Name = "Samsung Store", Location = "UK", Mode = "8:00-5:00", Id = 2 });
            db.Products.Add(new Product { Name = "Apple iPhone X", Description = "128Gb", StoreId = 1 });
            db.Products.Add(new Product { Name = "Apple iPhone XS", Description = "64Gb", StoreId = 1 });
            db.Products.Add(new Product { Name = "Samsung Galaxy S9", Description = "64Gb", StoreId = 2 });
            db.Products.Add(new Product { Name = "Samsung Galaxy S9+", Description = "128Gb", StoreId = 2 });
            db.SaveChanges();
        }
    }
}