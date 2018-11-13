using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestTask.Models;
using TestTask.Repositories;

namespace TestTask.Controllers
{
    public class DefaultController : ApiController
    {
        UnitOfWork db = new UnitOfWork();

        // GET: api/Default
        public IEnumerable<Store> Get()
        {
            return db.Stores.GetAll();
        }

        // GET: api/Default/5
        public IEnumerable<Product> Get(int id)
        {
            return db.Products.GetProductsByStore(id);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
