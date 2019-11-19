using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_prep.Models;

namespace test_prep.Controllers
{
    public class IndexController : Controller
    {
        [HttpPost]
        public ActionResult Index(Buyer info)
        {
            ViewBag.info = info;
            return View();
        }
    }
}