using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealView.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RealView.Models
{
    public class guest_resp
    {
        [Required]
        [DisplayName("Full Name:")] // model attribute & validation
        public string Name { get; set; }
        [Required(ErrorMessage = "Email or no go")]
        public string Email { get; set; }
        [Required(ErrorMessage = "bruh, how im gonna call yah")]
        public int Phone_number { get; set; }
        [Required(ErrorMessage = "dude...")]
        public bool? Comming { get; set; }
     }
}