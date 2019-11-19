using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_test //name space = folder
{
    class CustomerTest
    {
        //main method i guess
        static void Main(string[] args)
        {
            //make that customer object
            Customer customer_obj = new Customer();

            //set customer version number
            Customer.setVersionNumber(1);

            //display customer version number
            Console.WriteLine(" customer version: " + Customer.getVersionNumber());

            //set customers instance variables 
           
            customer_obj.setCustomerName("Elijah Allen ^-^");
            customer_obj.setCustomerAddress("TNRB, Brigham Young University, Provo, UT");
            customer_obj.setCustomerZip(84602);

            //print customer info
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Customer Name: " + customer_obj.getCustomerName());
            Console.WriteLine("Customer Address: " + customer_obj.getCustomerAddress());
            Console.WriteLine("Customer Zip: " + customer_obj.getCustomerZip());
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine();
            
            //pause al-display
           
            
            
            Console.WriteLine("Press enter to exit");
            Console.Read();
            //end this main                                      
        }
    }
}
