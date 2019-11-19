using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace creating_a_model_view_controller_video.Models
{
    public class Team
    {
        public string team_name { get; set; }

        /*public string team_name
        {
            get { return team_name}
            set { team_name = value; }
        }*/
        public int team_points { get; set; }
        public int team_rank { get; set; }
    }
}
