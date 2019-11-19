using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_practice1_0.Models;

namespace test_practice1_0.Controllers
{

    public class View_bookController : Controller
    {
        public static List<Book> l_books = new List<Book>();
        public static Book book_to_edit;
        public static int i_position;
        // GET: View_book
        public ActionResult Index(Book created_book)
        {           
                l_books.Add(created_book);
                return View(l_books);            
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {

             book_to_edit = l_books.Find(x => x.Book_ID == id);
            i_position = l_books.IndexOf(book_to_edit); //find the positon of the edit
            return View(book_to_edit);
        }

        [HttpPost]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                l_books.RemoveAt(i_position);//remove old copy
                if (l_books.Count == 0)
                {
                    return RedirectToAction("Index", book);
                }
                else
                {
                    l_books.Insert(i_position, book); //put eddited object back where it belongs 
                }
                return View("Index", l_books);
            }
            else
            {
                return View(book);
            }
        }
        public ActionResult Delete(int id)
        {
            book_to_edit = l_books.Find(x => x.Book_ID == id);
            i_position = l_books.IndexOf(book_to_edit); //find the positon of the edit
            l_books.RemoveAt(i_position);
            return View("Index", l_books);
        }
        public ActionResult Details(int id)
        {
            book_to_edit = l_books.Find(x => x.Book_ID == id);
            
            return View(book_to_edit);
        }
        public ActionResult View_list()
        {
            return View("Index", l_books);
        }
        public ActionResult Post_to_public()
        {
            return RedirectToAction("ViewOnly","View_only", l_books);
        }
    }
}