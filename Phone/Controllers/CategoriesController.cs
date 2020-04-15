using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Phone.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Categories()
        {
            return View();
        }
        public ActionResult AddCategory()
        {
            return View();
        }
        public ActionResult DeleteCategory()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
    }
}