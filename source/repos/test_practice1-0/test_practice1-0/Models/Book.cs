using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test_practice1_0.Models
{
    public class Book
    {
        [Required(ErrorMessage="Enter ID")]
        [DisplayName("Book ID")]
        public int Book_ID { get; set; }
        [Required(ErrorMessage = "Enter book name")]
        [DisplayName("Book Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter page number")]
        [DisplayName("Page number")]
        public int Page_number { get; set; }
        [Required(ErrorMessage = "Enter Author")]
        [DisplayName("Author")]
        public string Author { get; set; }

    }
}