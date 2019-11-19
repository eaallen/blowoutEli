using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Midterm.Models;

namespace Midterm.Controllers
{
    public class GenreController : Controller
    {
        public static List<Genre> list_genre = new List<Genre>();
        public static int pos;
        // GET: Genre
        public ActionResult Index()
        {
            return View(list_genre);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Genre genre)
        {
            if (ModelState.IsValid)
            {
                list_genre.Add(genre);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(genre);
            }
            
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            list_genre.Find(x => x.Genre_code == id);
            pos = list_genre.FindIndex(x => x.Genre_code == id);
            return View(list_genre.Find(x => x.Genre_code == id));
           
        }

        [HttpPost]
        public ActionResult Edit(Genre genre)
        {
            if (ModelState.IsValid)
            {/*
                var obj = list_genre.FirstOrDefault(x => x.Genre_code == genre.Genre_code);
                if (obj != null)
                {
                    obj = genre;
                }*/
                list_genre.RemoveAt(pos);
                list_genre.Insert(pos, genre);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(genre);
            }

        }

    }
}