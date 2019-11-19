using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test_prep_2_midterm.Models
{
    public class Color
    {
        [Required(ErrorMessage ="Enter the dang color")]
        [StringLength(10,ErrorMessage ="To long")]
        public string Color_name { get; set; }
    }
}