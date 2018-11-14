using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestTask.Interfaces;
using TestTask.Models;

namespace TestTask.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private StoreContext storeContext;

        public ProductRepository(StoreContext storeContext)
        {
            this.storeContext = storeContext;
        }

        public IEnumerable<Product> GetAll()
        {
            return storeContext.Products;
        }

        public Product GetById(int id)
        {
            return storeContext.Products.Find(id);
        }
    }
}