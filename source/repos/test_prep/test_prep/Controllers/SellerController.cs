using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_prep.Models;

namespace test_prep.Controllers
{
    public class SellerController : Controller
    {
        [HttpGet]
        public ActionResult Product_test()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Product_test(Product product)
        {
            return View();
        }
    }
}