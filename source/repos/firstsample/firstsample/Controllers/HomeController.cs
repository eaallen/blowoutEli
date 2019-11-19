using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using firstsample.Models;


namespace firstsample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;

            ViewBag.greeting = hour < 12 ? "Goodmorning" : "good afternoon";    // Viewbag is a dictionary
            return View();
        }

        public ActionResult RSVPForm ()
        {

            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(guest_response guest_response)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guest_response);
            }
            else
            {
                //Validation Error
                return View();
            }
        }
    }
}