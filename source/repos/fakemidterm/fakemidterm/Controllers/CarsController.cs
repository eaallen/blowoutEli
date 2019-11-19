using fakemidterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fakemidterm.Controllers
{
    public class CarsController : Controller
    {
        public static List<Car> list_cars = new List<Car>();
        // GET: Cars
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddCar()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddCar(Car car)
        {
            if (ModelState.IsValid)
            {
                list_cars.Add(car);
                return RedirectToAction("Index","ViewList",car);
            }
            else
            {
                return View(car);
            }
        }
    }
}