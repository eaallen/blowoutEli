using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test_prep_2_midterm.Models;
using System.Web.Mvc;

namespace test_prep_2_midterm.Controllers
{
    public class Handel_listController : Controller
    {
        public static List<Expo> l_expos = new List<Expo>();

        public static int position;

        // GET: Handel_list
        public ActionResult Index(Expo expo)
        {          
                l_expos.Add(expo);
                return View(l_expos);            
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {           
           // Expo chg_expo = l_expos.Find(x => x.Expo_ID == id);

            position = l_expos.FindIndex(x => x.Expo_ID == id);
            return View(l_expos[position]);
        }
        [HttpPost]
        public ActionResult Edit(Expo expo)
        {
            if (ModelState.IsValid)
            {
                l_expos.RemoveAt(position);
                if (l_expos.Count == 0)
                {
                    l_expos.Add(expo);
                    return View("Index",l_expos);
                }
                else
                {
                    l_expos.Insert(position, expo);
                    return View(l_expos);
                }
            }
            else
            {
                return View(expo);
            }
            
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            position = l_expos.FindIndex(x => x.Expo_ID == id);
            l_expos.RemoveAt(position);
            return RedirectToAction ("View_it",l_expos);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            Expo view_expo = l_expos.Find(x => x.Expo_ID == id);
            return View(view_expo);
        }

        public ActionResult View_it()
        {
            if (l_expos.Count == 0)
            {
                return View("Index");
            }
            else
            {
                return View("Index",l_expos);
            }
        }
    }
}