using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test_prep_2_midterm.Models
{
    public class Expo
    {

        [Required(ErrorMessage = "ID please")]
        [DisplayName("ID")]
        public int Expo_ID { get; set; }
        [Required(ErrorMessage ="enter color")]
        [DisplayName("Color")]
        public Color Color { get; set; }
        [Required(ErrorMessage = "is it used")]
        [DisplayName("Used?")]
        public bool? Used { get; set; }
        
    }
}