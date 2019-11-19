using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MidtermReview1.Models
{
    public class Team
    {
        [Required(ErrorMessage ="Enter the dang code")]
        [Display(Name = "Team code")]
        [StringLength(5,MinimumLength =2, ErrorMessage ="Plese keep code 2 to 5 charecters long")]
        public string Team_code { get; set; }

        [Required(ErrorMessage = "Enter the dang name")]
        [Display(Name = "Team Name")]
        
        public string Team_name { get; set; }
    }
}