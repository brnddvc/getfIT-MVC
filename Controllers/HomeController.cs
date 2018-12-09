using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace getfitEF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize(Roles = "IT strucnjak")]
        public ActionResult Role()
        {
            return View();
        }

        public ActionResult Treneri()
        {
            return View();
        }

        public ActionResult Trening()
        {
            return View();
        }
    }
}