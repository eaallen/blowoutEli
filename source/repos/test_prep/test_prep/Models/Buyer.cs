using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test_prep.Models
{
    public class Buyer: User
    {
        [Required]
        public bool? affirmation { get; set; }
    }
}