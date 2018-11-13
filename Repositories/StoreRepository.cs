using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestTask.Interfaces;
using TestTask.Models;

namespace TestTask.Repositories
{
    public class StoreRepository : IRepository<Store>
    {
        private StoreContext storeContext;

        public StoreRepository(StoreContext storeContext)
        {
            this.storeContext = storeContext;
        }

        public IEnumerable<Store> GetAll()
        {
            return storeContext.Stores;
        }

        public Store GetById(int id)
        {
            return storeContext.Stores.Find(id);
        }

        public IEnumerable<Store> GetProductsByStore(int id)
        {
            throw new Exception();
        }
    }
}