using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fakemidterm.Models
{
    public class Car
    {
        [Required(ErrorMessage ="VIN is required")]
        [DisplayName("Vehicle ID")]
        [StringLength(4,ErrorMessage ="only 4 digits")]
        public string VIN { get; set; }
        public string Make { get; set; }
    }

}