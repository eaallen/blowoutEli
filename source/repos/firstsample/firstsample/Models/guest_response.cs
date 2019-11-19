using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using firstsample.Models;
using System.ComponentModel.DataAnnotations;
using System.Windows;

namespace firstsample.Models
{
    public class guest_response
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify if you will attend")]
        public bool? WillAttend { get; set; }

    }
    
}