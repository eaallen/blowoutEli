using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_practice1_0.Models;

namespace test_practice1_0.Controllers
{
    public class Handel_bookController : Controller
    {
       // public static List<Book> l_books = new List<Book>();
        // GET: Handel_book
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Book book)
        {
            if (ModelState.IsValid)
            {
                //l_books.Add(book);
                return RedirectToAction("Index","View_book",book);
            }
            else
            {
                return View(book);
            }
        }
    }
}