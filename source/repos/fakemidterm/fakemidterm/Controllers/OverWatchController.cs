using fakemidterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fakemidterm.Controllers
{
    
    public class OverWatchController : Controller
    {
        public static Car car;
        // GET: OverWatch
        public ActionResult Edit(Car mycar)
        {
            car = mycar;
            return View();
        }
        public ActionResult Detail(int vin)
        {
            return View();
        }
        public ActionResult Delete(int vin)
        {
            return View();
        }
    }
}