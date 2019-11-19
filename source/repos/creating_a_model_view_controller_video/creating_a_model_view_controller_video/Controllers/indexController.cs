using creating_a_model_view_controller_video.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace creating_a_model_view_controller_video.Controllers
{
    public class indexController : Controller
    {
        // GET: index
        public ActionResult Index()
        {
            List<Soccer_team> listSoccer_team_all = new List<Soccer_team>();

            List<Soccer_team> listSorted          = new List<Soccer_team>();
            int i_team_rank = 0;


            // load data
            listSoccer_team_all.Add(new Soccer_team("Rsl", 35));
            listSoccer_team_all.Add(new Soccer_team("Colorado", 24));
            listSoccer_team_all.Add(new Soccer_team("FC Dallas", 42));
            listSoccer_team_all.Add(new Soccer_team("Sporting KC", 39));
            listSoccer_team_all.Add(new Soccer_team("San Jose", 12));
            listSoccer_team_all.Add(new Soccer_team("Houston", 1));
            listSoccer_team_all.Add(new Soccer_team("Seattle", 153));
            listSoccer_team_all.Add(new Soccer_team("Vancouver", 215));
            listSoccer_team_all.Add(new Soccer_team("Minnesota", 5));
            listSoccer_team_all.Add(new Soccer_team("Portland", 65));
            listSoccer_team_all.Add(new Soccer_team("LA Galaxy", 85));
            listSoccer_team_all.Add(new Soccer_team("LAFC", 17));
            //sort
            listSorted = listSoccer_team_all.OrderByDescending(o_team => o_team.team_points).ToList();
            

            ViewBag.tls = listSorted;

            //view bag/foreach
            foreach (Soccer_team o_team in listSorted)
            {
                //Get it all into HTNL
                ViewBag.Output = "<table id= 'customers'>";
                ViewBag.Output += "<tr>";
                ViewBag.Output += "<th>Ranking </th>";
                ViewBag.Output += "<th>Team Name</th>";
                ViewBag.Output += "<th>Score</th>";
                ViewBag.Output += "</tr>";
                //ViewBag.Output += "<tr>";
                ViewBag.Team_names += "<tr>" + "<td>" + ++i_team_rank + "</td>" + 
                                    "<td>" + o_team.team_name + "</td>" + 
                                    "<td>" + o_team.team_points + "</td>" + "</tr>";
                //ViewBag.Output += "</tr>";
               ViewBag.Output += ViewBag.Team_names;
                ViewBag.Output += "</table>";

            }


            return View();
        }
    }
}