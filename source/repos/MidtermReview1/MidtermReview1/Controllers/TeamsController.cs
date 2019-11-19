using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MidtermReview1.Models;

namespace MidtermReview1.Controllers
{
    public class TeamsController : Controller
    {
        public static List<Team> team_list = new List<Team>();
        public int pos_in_list;
        // GET: Teams
        public ActionResult Index()
        {
            return View(team_list);
        }
        
        [HttpGet]
        public ActionResult Create() // add a new Team object
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Team team)
        {
            if (ModelState.IsValid)
            {
                team_list.Add(team);
                return RedirectToAction("Index");
            }
            else
            {
                return View(team);
            }
        }
        [HttpGet]
        public ActionResult Edit(string code)
        {
            team_list.Find(x => x.Team_code == code);
            pos_in_list = team_list.FindIndex(x => x.Team_code == code);
            return View(team_list.Find(x => x.Team_code == code));
        }
        public ActionResult Edit(Team team)
        {
            if(ModelState.IsValid)
            {
                var obj = team_list.FirstOrDefault(x => x.Team_code == team.Team_code); // this does the same as below but if it cannot find the matching Team_code value it will return null 
                                                                                        //team_list.RemoveAt(pos_in_list);
                                                                                        //team_list.Insert(pos_in_list, team);
                if (obj != null)
                {
                    obj.Team_name = team.Team_name;
                }
                return RedirectToAction("Index");                                                                        
            }
            else
            {
                return View();
            }
        }
    }

}