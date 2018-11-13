using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestTask.Interfaces;
using TestTask.Models;

namespace TestTask.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private StoreContext storeContext;
        private StoreRepository storeRepository;
        private ProductRepository productRepository;

        public UnitOfWork()
        {
            storeContext = new StoreContext();
        }

        public IRepository<Store> Stores
        {
            get
            {
                if (storeRepository == null)
                    storeRepository = new StoreRepository(storeContext);
                return storeRepository;
            }
        }

        public IRepository<Product> Products
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(storeContext);
                return productRepository;
            }
        }

        public void Save()
        {
            storeContext.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    storeContext.Dispose();
                }

                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}