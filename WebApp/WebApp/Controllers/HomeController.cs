using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Home";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Recipes()
        {
            return View();
        }

        public ActionResult Store()
        {
            return View();
        }

        public ActionResult Upload()
        {
            return View();
        }

        public ActionResult Recipe()
        {
            return View();
        }
    }
}
