using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_test
{
    class Customer
    {
        private static int versionNumber;
        private string customerName;
        private string customerAddress;
        private int customerZip;

        public Customer()
        {

        }

        public Customer(int versionNumber, string customerName, string customerAddress, int customerZip)
        {

        }
       public static int getVersionNumber()
        {
            return versionNumber;
        }

        public static void setVersionNumber(int setNum)
        {
            versionNumber = setNum;  
        }

        public string getCustomerName()
        {
            return this.customerName; 
        }

        public void setCustomerName(string name)
        {
            this.customerName = name; 
        }

        public string getCustomerAddress()
        {
            return this.customerAddress; 
        }

        public void setCustomerAddress(string address)
        {
            this.customerAddress = address; 
        }

        public int getCustomerZip()
        {
            return this.customerZip;
        }

        public void setCustomerZip(int zip_code)
        {
            this.customerZip = zip_code;
        }


    }
}
