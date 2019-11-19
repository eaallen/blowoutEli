using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MidtermReview1.Models
{
    public class Player
    {
        [Required]
        [Display(Name = "Player Code")]
        public int Player_code { get; set; }
        [Required]
        [Display(Name = "first name")]
        public string Player_fname { get; set; }
        [Required]
        [Display(Name = "last name")]
        public string Player_lname { get; set; }
        [Required]
        [Display(Name = "Position")]
        public string Pos_code { get; set; }
        [Required]
        [Display(Name = "Team Name")]
        public string Team_code { get; set; }

    }
}