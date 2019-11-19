using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using learingviews.Models;


namespace learingviews.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int i_month_num = DateTime.Now.Month;
            var month = new DateTime(1,i_month_num,1).ToString("MMMM");
            ViewBag.greetings = "The month is " + month;
            return View();
        }


        [HttpGet]
        public ViewResult RsvpForm()
        {
            
            return View();
        }

        
        [HttpPost]
        public ViewResult RsvpForm(form response)
        {
            if(ModelState.IsValid)
            {
                return View("Thanks", response);
            }
            else
            {
                return View();
            }
           
        }


    }
}