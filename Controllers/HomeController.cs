using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTask.Repositories;

namespace TestTask.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork db = new UnitOfWork();

        public ActionResult Index()
        {
            return View(db.Stores.GetAll());
        }

        public ActionResult Products(int id)
        {
            return PartialView(db.Products.GetProductsByStore(id));
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