using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitTestProjectDotNetMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is an application at Git";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This is a Contact Page Only For Branch2.";

            return View();
        }
    }
}