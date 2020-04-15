using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Phone.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Products()
        {
            return View();
        }
        public ActionResult AddProducts()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
    }
}