using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_prep.Models;

namespace test_prep.Controllers
{
    public class HomeController : Controller
    {
        public static List<User> users = new List<User>();
        public static User seller;

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.users = users.Count();
            return View();
        }
        [HttpGet]
        public ActionResult create_account()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create_account(User user_info)
        {
            if (ModelState.IsValid)
            {
                
                user_info.User_ID = users.Count() + 1000;
                users.Add(user_info);
                return View("Index",users);
            }
            else
            {
                return View(user_info);
            }
        }
        [HttpGet]
        public ActionResult Product_test(int id)
        {

            //seller.User_seller_id = users;
            seller = users.Find(x => x.User_ID == id);
            return View();
        }

        [HttpPost]
        public ActionResult Product_test(Product product)
        {
            if (ModelState.IsValid)
            {
                product.Product_ID = 1;
                seller.d_Products = product;
               // seller.Dd_Products.Add(1, product);
                return RedirectToAction("Index",users);
            }
            else
            {
                return View();
            }
        }
    }
}