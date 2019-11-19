using RealView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace RealView.Controllers
{
    public class HomeController : Controller
    {
        public static List<guest_resp> list_guest_rep = new List<guest_resp>();
        // GET: Home
        public ActionResult Index()
        {
            int time = DateTime.Now.Month;
            string month = time.ToString();
            ViewBag.time = time;
            ViewBag.month = month;
            return View("Index");
        }

        [HttpGet]
        public ViewResult rsvp_form()
        {
            return View();
        }

        [HttpPost]
        public ViewResult rsvp_form(guest_resp response)
        {
            if (ModelState.IsValid)
            {
                return View("thank_you", response);
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult mytest()
        {

            return View();
        }
        [HttpPost]
        public ActionResult mytest(guest_resp response)
        {

            if (ModelState.IsValid)
            {
                list_guest_rep.Add(response);
                return RedirectToAction("ListGuests");
            }
            else
            {
                return View(response);
            }
        }
        [HttpGet]
        public ActionResult ListGuests()
        {
            return View(list_guest_rep);
        }

        [HttpGet]
        public ActionResult Edit(string sname)
        {
            return View(list_guest_rep.Find(x => x.Name == sname));
        }
        [HttpPost]
        public ActionResult Edit(guest_resp response)
        {
            if(ModelState.IsValid)
            {
                var obj = list_guest_rep.FirstOrDefault(x => x.Name == response.Name);
                //list_guest_rep.Add(response);
                if (obj != null)
                {
                    obj.Email = response.Email;
                    obj.Phone_number = response.Phone_number;
                    obj.Comming = response.Comming;

                }
                return RedirectToAction("ListGuests",list_guest_rep);
            }
            else
            {
                return View(response);
            }
        }
    }
}