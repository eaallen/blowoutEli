using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using test_prep.Models;
namespace test_prep.Models
{
    public class User
    {


        public int User_ID { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Enter first name")]
        public string First_name { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Enter a your last name")]
        public string Last_name { get; set; }

        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "Enter your phone number")]
        public string Phone_number { get; set; }

        [DisplayName("Age")]
        [Required(ErrorMessage = "Enter your age")]
        public int Age { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Enter your email")]
        public string Email { get; set; }

        [DisplayName("Latitude")]
        [Required(ErrorMessage = "Enter your latitude")]
        public float Latitude { get; set; }

        [DisplayName("Longitude")]
        [Required(ErrorMessage = "Enter your longitude")]
        public float Longitude { get; set; }

        public object d_Products { get; set; }

        /*private List<object> D_dictionary;

        public List<object> dictionary
        {
            get { return D_dictionary; }
            set { D_dictionary.Add value; }
        }*/
    }
}




    