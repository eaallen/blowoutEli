using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class BottonController : Controller
    {
        // GET: Button
        public ActionResult Button()
        {
            Queue<string> myque = new Queue<string>();
            Dictionary<string, int> mydict = new Dictionary<string, int>();
            randomName();
            ViewBag.name = randomName();
            string cust_name;
            int total_num_of_burg = 0;
            for (int icount = 0; icount < 100; icount++)
            {
                int number_of_burgers = randomNumberInRange();

                cust_name = randomName();
                myque.Enqueue(cust_name);
                if (mydict.ContainsKey(cust_name) == true)
                {
                    mydict[cust_name] += number_of_burgers;
                }
                else
                {
                    mydict.Add(cust_name, number_of_burgers);
                }

                total_num_of_burg += number_of_burgers;
            }

            ViewBag.que_count = myque.Count; //the for loop worked
            ViewBag.t = total_num_of_burg;

            /*IEnumerator<string> MyQueueEnumerator = myque.GetEnumerator();
            
            while (MyQueueEnumerator.MoveNext())
            {
                string myValue = myque.Peek();
            }
            */
            //viewbag 

            // This sorts the dictionary
            var itemsSorted = from pair
                              in mydict
                              orderby pair.Key ascending
                              select pair;

            ViewBag.a = "<table id= 'customers' align='center'>" +
                                "<tr>" +
                                "<th>" +
                                    "Name" +
                                "</th>" +
                                "<th>" +
                                    "Hamburgers Ordered" +
                                "</th>";
            foreach (KeyValuePair<string, int> kvp in itemsSorted)
            {
                /*ViewBag.arr = "<table>";
                ViewBag.arr += "<tr>";
                ViewBag.arr += "<th>Ranking </th>";
                ViewBag.arr += "<th>Team Name</th>";
                ViewBag.arr += "</tr>";*/

                ViewBag.a +=
                                "<tr>" +
                                "<td>" + kvp.Key + "</td>" +
                                "<td>" + kvp.Value + "</td>" +
                                "</tr>";


                //ViewBag.arr = "</table>";

            }
            ViewBag.a += "</table>";


            return View();



        }


        public static Random random = new Random(); // new object random is a data type

        public static string randomName()
        {
            string[] names = new string[8] { "Dan Morain", "Emily Bell", "Carol Roche", "Ann Rose", "John Miller", "Greg Anderson", "Arthur McKinney", "Joann Fisher" };
            int randomIndex = Convert.ToInt32(random.NextDouble() * 7);
            return names[randomIndex];
        }

        public static int randomNumberInRange()
        {
            return Convert.ToInt32(random.NextDouble() * 20);
        }
            
        
    }
}