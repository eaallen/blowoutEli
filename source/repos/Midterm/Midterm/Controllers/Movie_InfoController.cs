using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Midterm.Models;
/*
 For the Movie_Info model, you will allow the user to add, edit, and show the list of movies. However, on
the add view and edit view, you will need to use drop down lists for the Media type (display the
Media_Desc and store the Media_Code) and the Genre (display the Genre_Desc and store the
Genre_Code).
*/
namespace Midterm.Controllers
{
    public class Movie_InfoController : Controller
    {
        public static List<Movie_Info> list_movie = new List<Movie_Info>();
        public static int pos;

        // GET: Movie_Info
        public ActionResult Index()
        {
            return View(list_movie);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Genre = GenreController.list_genre;
            ViewBag.Media = Media_TypeController.list_media;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie_Info movie)
        {
            if (ModelState.IsValid)
            {
                list_movie.Add(movie);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(movie);
            }

        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            list_movie.Find(x => x.Movie_code == id);
            pos = list_movie.FindIndex(x => x.Movie_code == id);
            return View(list_movie.Find(x => x.Movie_code == id));

        }

        [HttpPost]
        public ActionResult Edit(Movie_Info movie)
        {
            if (ModelState.IsValid)
            {
                /*var obj = list_movie.FirstOrDefault(x => x.Movie_code == movie.Movie_code);
                if (obj != null)
                {
                    obj = movie;
                }*/
                list_movie.RemoveAt(pos);
                list_movie.Insert(pos, movie);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(movie);
            }

        }

    }
}