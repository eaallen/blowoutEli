using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_test
{
    public class Person
    {
        private static int VersionNumber;

        private string name;

        public Person()
        {

        }
        public Person(string name, int VersionNumber)
        {

        }

        public string get_name ()
        {
            return this.name;
        }

        public void set_name(string name)
        {
            this.name = name;
        }

    }
}
