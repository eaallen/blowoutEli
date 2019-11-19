using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MidtermReview1.Models;

namespace MidtermReview1.Controllers
{
    public class PositionsController : Controller
    {
        public static List<Position> list_pos = new List<Position>();
        // GET: Positions
        public ActionResult Index()
        {
            return View(list_pos);
        }
        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Create(Position player)
        {
            if (ModelState.IsValid)
            {
                list_pos.Add(player);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }

        public ActionResult Edit(string id)
        {
            list_pos.Find(x => x.Pos_code == id);

            return View(list_pos.Find(x => x.Pos_code == id));
        }
        [HttpPost]
        public ActionResult Edit(Position player)
        {
            if (ModelState.IsValid)
            {
                var obj = list_pos.FirstOrDefault(x => x.Pos_code == player.Pos_code);
                if (obj != null)
                {
                    obj = player;
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(player);
            }
        }

    }
}