using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
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
        public ActionResult Rentals()
        {
            ViewBag.Clarinet = "Clarinet";
            ViewBag.Flute = "Flute";
            ViewBag.Saxophone = "Saxophone";
            ViewBag.Trumpet = "Trumpet";
            ViewBag.Trombone = "Trombone";
            ViewBag.Tuba = "Tuba";

            return View();
        }

        public ActionResult Show_rental(string instrament)
        {
            ViewBag.info = instrament;
            return View();
        }

    }
}