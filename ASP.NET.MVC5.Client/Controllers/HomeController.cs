using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET.MVC5.Client.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            

            return View();
        }


        public ActionResult Home()
        {
            return View();
        }

        public ActionResult FAQ()
        {
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
        public ActionResult Privacy()
        {

            return View();
        }
        public ActionResult TermsOfUse()
        {

            return View();
        }

        
    }
}