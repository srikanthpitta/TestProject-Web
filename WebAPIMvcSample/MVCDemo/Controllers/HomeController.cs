using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is the Index action method";
        }

        public string About()
        {
            //ViewBag.Message = "Your application description page.";

            return "This is Sample MVC application";
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}