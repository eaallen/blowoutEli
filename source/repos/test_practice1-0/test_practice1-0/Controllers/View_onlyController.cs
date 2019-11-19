using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_practice1_0.Models;

namespace test_practice1_0.Controllers
{
    public class View_onlyController : Controller
    {
        public static List<Book> list_books = new List<Book>();
        // GET: View_only
        public ActionResult ViewOnly(List<Book> books)
        {
            
            return View (books);
        }
    }
}