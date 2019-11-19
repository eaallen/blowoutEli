using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MidtermReview1.Models;

namespace MidtermReview1.Controllers
{
    public class PlayersController : Controller
    {

        public static List<Player> player_list = new List<Player>();
        // GET: Players
        public ActionResult Index()
        {
            if(player_list != null)
            {
                foreach(Player player in player_list)
                {
                    player.Player_code = player_list.IndexOf(player) + 1;
                }
            }
            return View(player_list);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Teams = TeamsController.team_list;
            ViewBag.Pos = PositionsController.list_pos;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Player player)
        {
            if (ModelState.IsValid)
            {
                //player.Player_code = player_list.Count() + 1; 
                player_list.Add(player);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
                
        }

        public ActionResult Edit(int id)
        {
            player_list.Find(x => x.Player_code == id);

            return View(player_list.Find(x => x.Player_code == id)); 
        }
        [HttpPost]
        public ActionResult Edit(Player player)
        {
            if(ModelState.IsValid)
            {
                var obj = player_list.FirstOrDefault(x => x.Player_code == player.Player_code);
                if(obj!= null)
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