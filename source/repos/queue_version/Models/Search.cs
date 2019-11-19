using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using queue_version.Models;
using System.ComponentModel.DataAnnotations;

namespace queue_version.Models
{
    public class Search
    {
        public Search()
        {

        }
            [Required]
            public string find { get; set; }

        public static implicit operator string(Search v)
        {
            throw new NotImplementedException();
        }


        /*public ActionResult search()
        {

        }*/
    }
}