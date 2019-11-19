using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


//enre_Code string 3 (COM, ACT, SCI, DRA, ROM)
//Genre_Desc string 25 (Comedy, Action, Sci-fi, Drama, Romance)
namespace Midterm.Models
{
    public class Genre
    {
        [Required(ErrorMessage = "Enter 3 letter code")]
        [StringLength(3)]
        [Display(Name ="Genre Code")]
        public string Genre_code { get; set; }

        [Required(ErrorMessage = "Enter 25 letter code")]
        [StringLength(25)]
        [Display(Name ="Description")]
        public string Genre_desc { get; set; }
    }
}