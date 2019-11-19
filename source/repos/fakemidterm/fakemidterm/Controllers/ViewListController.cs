using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fakemidterm.Models;

namespace fakemidterm.Controllers
{
    public class ViewListController : Controller
    {
        public static List<Car> list_cars = new List<Car>();
        public static Car car;
        // GET: ViewList
        [HttpGet]
        public ActionResult Index(Car car)
        {
            list_cars.Add(car);
            return View("Index",list_cars);
        }
        [HttpGet]
        public ActionResult Edit(string vin)
        {
            //list_cars.BinarySearch()
            car = list_cars.Find(x=>x.VIN == vin);
            list_cars.Remove(car);
            return View(car);
        }

        [HttpPost]
        public ActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                
                
                return RedirectToAction("Index",car);
            }
            else
            {
                return View(car);
            }
        }
    }
}