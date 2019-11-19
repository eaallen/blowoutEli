using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


//Media_Code string 3 (For example, it could be something like BLU, DVD, VHS, DIG,
//required, max length 3, min 1, error message)
//Media_Desc string 20 (For example, it could be something like Blu-ray, DVD, VHS,
//Digital, required, max length 20, error message)
namespace Midterm.Models
{
    public class Media_Type
    {
        [Required(ErrorMessage = "Enter 3 letter code")]
        [StringLength(3,MinimumLength =1,ErrorMessage ="1 to 3 letter code")]
        [Display(Name = "Media Code")]
        public string Meida_code { get; set; }

        [Required(ErrorMessage = "Enter Descrpition")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "20 characters MAX  1 character MIN")]
        [Display(Name = "Media Description")]
        public string Meida_desc { get; set; }

    }
}