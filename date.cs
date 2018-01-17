using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DeclaringConstants
{
    class Program
    {

        static void Main(string[] args)
        {




            Console.WriteLine("Enter first date the following format:");
            string dateString = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("Enter second date:");
            string dateString2 = Convert.ToString(Console.ReadLine());

            //string span = TimeSpan.Parse(dateValue);
            Date(dateString, dateString2);

            Console.ReadLine();


          
            
         
        }

        static void Date(string dateInput, string dateInput2)
        {
            //string dateString;
            //string dateString2 = "";
            DateTime dateValue;
            DateTime dateValue2;
            DateTime ds;
            DateTime ds2;


            if (DateTime.TryParse(dateInput, out dateValue))
            {
                Console.WriteLine("Converted '{0}' to {1} ({2}).", dateInput, dateValue, dateValue.Kind);

                ds = dateValue;
            }

            else
                Console.WriteLine("Unable to parse '{0}'.", dateInput);

            if (DateTime.TryParse(dateInput2, out dateValue2))
            {
                Console.WriteLine("Converted '{0}' to {1} ({2}).", dateInput, dateValue, dateValue.Kind);

                ds2 = dateValue2;
            }

            else
                Console.WriteLine("Unable to parse '{0}'.", dateInput);

            TimeSpan span = ds -  ds2;
            Console.WriteLine(span);

        }

    }

       

}
