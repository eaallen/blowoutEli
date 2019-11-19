using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_prep_2_midterm.Models;

namespace test_prep_2_midterm.Controllers
{
    public class DefaultController : Controller
    {
        public static List<Color> list_color = new List<Color>();

        // GET: Default
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Color color)
        {
            if (ModelState.IsValid)
            {
                list_color.Add(color);
                return View ("Index", list_color);
            }
            else
            {
                return View(color);
            }
        }

    }
}