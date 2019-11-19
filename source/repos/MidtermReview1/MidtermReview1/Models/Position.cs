using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MidtermReview1.Models
{
    public class Position
    {
        [Required]
        [Display(Name ="Position Code")]
        public string Pos_code { get; set; }
        [Required]
        [Display(Name ="Position name")]
        [StringLength(20,MinimumLength = 3)]
        public string Pos_desc { get; set; }
    }
}