using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class HomeworkController : Controller
    {   // instantiates a new list
        
        public static List<Homework> HomeworkList = new List<Homework>();
        // GET: Homework
        public ActionResult ShowHomework()
        {
            return View(HomeworkList);
        }

        [HttpGet]
        public ActionResult AddHomework()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddHomework(Homework myHomework)
        {
            if (ModelState.IsValid)
            { 
                HomeworkList.Add(myHomework);
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View(myHomework);
            }
        }

    }

}

