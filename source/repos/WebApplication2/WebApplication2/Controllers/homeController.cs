using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            List<string> lstnames = new List<string>();
            lstnames.Add("cotc");
            lstnames.Add("eli");
            lstnames.Add("joe");
            foreach(string sTeam in lstnames)
            {
                ViewBag.Teams = ViewBag.Teams + sTeam + "<br>";
            }

            return View();
        }
    }
}