using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


/*
 * Customer_Code int (User does not input, auto-generated when added. Start at 1 and
           continue to increment upon addition of customers)
Customer_First_Name string 25 (required, max length 25, error message)
Customer_Last_Name string 30 (required, max length 30, error message)
Customer_Email string 50 (not required, make sure the model validates to be an email,
error messag
 
     */
namespace Midterm.Models
{
    public class Customer
    {
        [Display(Name="Customer ID")]
        public int Customer_Code { get; set; }

        [Required(ErrorMessage = "Enter first name")]
        [Display(Name = "First Name")]
        [StringLength(25,ErrorMessage = "max length of 25 characters")]
        public string Customer_first_name { get; set; }

        [Required(ErrorMessage = "Enter last name ")]
        [Display(Name ="Last Name")]
        [StringLength(30,ErrorMessage = "max length of 30 characters")]
        public string Customer_last_name { get; set; }

        [Required(ErrorMessage = "Enter email address")]
        [Display(Name ="Email Address")]
        [StringLength(50,ErrorMessage = "max length of 50 characters")]
        public string Customer_Email { get; set; }
    }
}