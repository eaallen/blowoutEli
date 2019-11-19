using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_prep_2_midterm.Models;

namespace test_prep_2_midterm.Controllers
{
    public class Make_expoController : Controller
    {
        // GET: Make_expo
        public ActionResult Make()
        {
            ViewBag.Colors = DefaultController.list_color;
            return View();
        }

        [HttpPost]
        public ActionResult Make(Expo expo)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index","Handel_list",expo);
            }
            else
            {
                return View(expo);
            }
        }
    }
}