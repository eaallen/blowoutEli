using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/*
Movie_Code string 5 user determines, required, max length 5, error message
Movie_Title string 40 required, max length 40, error message
Genre_Code string 3 required, dropdown list from Genre in the view
Media_Code string 3 required, dropdown list from Media_Type in the view*/

namespace Midterm.Models
{
    public class Movie_Info
    {
        [Required(ErrorMessage = "Enter code")]
        [StringLength(5, MinimumLength = 1, ErrorMessage = "5 letters max")]
        [Display(Name = "Movie Code")]
        public string Movie_code { get; set; }

        [Required(ErrorMessage = "Enter Title")]
        [StringLength(5, MinimumLength = 1, ErrorMessage = "5 letters max")]
        [Display(Name = "Movie Title")]
        public string Movie_title { get; set; }

        [Required(ErrorMessage = "Enter code")]        
        [Display(Name = "Genre Code")]
        public string Genre_code { get; set; }

        [Required(ErrorMessage = "Enter code")]
        [Display(Name = "Media Code")]
        public string Media_code { get; set; }
    }
}