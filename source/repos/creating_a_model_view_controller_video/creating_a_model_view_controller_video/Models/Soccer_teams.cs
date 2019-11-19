using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace creating_a_model_view_controller_video.Models
{
    public class Soccer_team : Team
    {
        public int draw { get; set; }
        public int goals_for { get; set; }
        public int goals_against { get; set; }
        public int differantial { get; set; }
        public int points { get; set; }

        public Soccer_team()
        {
            base.team_name = "New Team";
            base.team_points = 0;
        }
        public Soccer_team(string s_name, int i_points)
        {
            base.team_name = s_name;
            base.team_points = i_points;
            


        }

    }
}