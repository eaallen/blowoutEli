using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Midterm.Models;

namespace Midterm.Controllers
{
    public class CustomerController : Controller
    {
        public static List<Customer> list_customers = new List<Customer>();
        public static int pos;
        // GET: Customer
        public ActionResult Index()
        {
            return View(list_customers);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.Customer_Code = list_customers.Count()+ 1;
                list_customers.Add(customer);
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View(customer);
            }

        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            list_customers.Find(x => x.Customer_Code == id);
            pos = list_customers.FindIndex(x => x.Customer_Code == id);
            return View(list_customers.Find(x => x.Customer_Code == id));
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {/*
                var obj = list_customers.FirstOrDefault(x => x.Customer_Code == customer.Customer_Code);
                if (obj != null)
                {
                    obj = customer;
                }*/

                list_customers.RemoveAt(pos);
                list_customers.Insert(pos, customer);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(customer);
            }

        }
    }
}