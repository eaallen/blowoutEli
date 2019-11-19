using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_prep.Models;

namespace test_prep.Controllers
{
    public class Buyer_cController : Controller
    {
        [HttpGet]
        public ActionResult IndexRsvp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IndexRsvp(Buyer info)
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View(info);
            }
            
        }
    }
}