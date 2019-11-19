using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test_prep.Models
{
    public class Product
    {
        public int Product_ID { get; set; }

        [Required(ErrorMessage = "Please place a description")]
        [DisplayName("Product type")]
        public P_type Product_type { get; set; }

        [Required(ErrorMessage = "Please place a description")]
        
        public string Description { get; set; }

        [Required(ErrorMessage = "Input price")]
        
        public float Price { get; set; }

        
        [DisplayName("Used")]
        public bool Used { get; set; }
        


    }

    public enum P_type
    {

        Automobile,
        Bike,
        Entertainment,
        Gift_card,
        Shoes,
        Clothing,
        Pet,
        Furniture,
        Outdoors,
        Camping,
        Sports


    }
}