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




            Console.WriteLine("This program will check, given two numbers, if each corresponding place");
            Console.WriteLine("in the two numbers (ones, tens, hundreds, ...) sums to the same total.");
            Console.WriteLine("Enter integer value: ");
            string number1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter another integer value with the same number of digits as previously:");
            string number2 = Convert.ToString(Console.ReadLine());
            int a = number1.Length;
            int b = number2.Length;
            
            if (a == b)
            {
                Math(number1, number2);
            }

            else
            { Console.WriteLine("The same number of digits, please."); }

            Console.ReadKey();
        }

        static void Math(string number1, string number2)
        {
            int a = number1.Length;
            int length = a - 1;
            int num = a;
            //string myString = "";
            int combined = 0;
            int letter = 0;

            while (num > 0)
            {
                letter = Int32.Parse(number1.Substring(length,1));
                //Console.WriteLine(letter);
                int letter2 = Int32.Parse(number2.Substring(length,1));
                combined = combined + letter + letter2;

                Console.WriteLine(combined);

                if (combined == (letter + letter2))
                {
                    Console.WriteLine("Equal");
                }

                else
                {
                    Console.WriteLine("False");
                }
                //myString = combined.ToString();
                
                length--;
                num--;
            }
            Console.WriteLine(combined);
            Console.WriteLine(letter);
            if (combined / (a * 2) == letter)
            {
                Console.WriteLine("True");
            }

            else
            {
                Console.WriteLine("False");
            }

        }

    }

       

}
