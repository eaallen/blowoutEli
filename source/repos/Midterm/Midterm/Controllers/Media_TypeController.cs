using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Midterm.Models;

namespace Midterm.Controllers
{
    public class Media_TypeController : Controller
    {
        public static List<Media_Type> list_media = new List<Media_Type>();
        public static int pos;
        // GET: Media_Type
        public ActionResult Index()
        {
            return View(list_media);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Media_Type media_Type)
        {
            if (ModelState.IsValid)
            {
                list_media.Add(media_Type);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(media_Type);
            }

        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            list_media.Find(x => x.Meida_code == id);
            pos = list_media.FindIndex(x => x.Meida_code == id);
            return View(list_media.Find(x => x.Meida_code == id));

        }

        [HttpPost]
        public ActionResult Edit(Media_Type media)
        {
            if (ModelState.IsValid)
            {/*
                var obj = list_media.FirstOrDefault(x => x.Meida_code == media.Meida_code);
                if (obj != null)
                {
                    obj = media;
                }*/
                list_media.RemoveAt(pos);
                list_media.Insert(pos, media);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(media);
            }

        }


    }
}