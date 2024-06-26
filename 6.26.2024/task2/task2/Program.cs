using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\nInput first integer:");

            //int x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Input second integer:");

            //int y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lowest of three: " + Math.Min(x,  y));

            /////////////////////////////////////////////////////////////

            //int num;
            //Console.Write("\n\n");  
            //Console.Write("Check whether a number is positive or negative:\n");  
            //Console.Write("----------------------------------------------");  
            //Console.Write("\n\n");  
            //Console.Write("Input an integer : ");  
            //num = Convert.ToInt32(Console.ReadLine()); 

            //if (num >= 0)  
            //    Console.WriteLine("{0} is a positive number.\n", num);  
            //else
            //    Console.WriteLine("{0} is a negative number. \n", num);  

            ///////////////////////////////////////////////////////////////////////
            ///
            //int number = -7;


            //string signMessage = (number > 0) ? "+"
            //                    : (number < 0) ? "-"
            //                    : "The number is zero.";


            //Console.WriteLine(signMessage);
            //Console.ReadKey();


            ///////////////////////////////////////////////////
            //int num1 = 0;
            //int num2 = -1;
            //int num3 = 4;

            //int[] numbers = { num1, num2, num3 };

            //Array.Sort(numbers);


            //Console.WriteLine($"{numbers[0]}, {numbers[1]}, {numbers[2]}");

            //////////////////////////////////////////////////////////////////////////////

            //int num1 = -5;
            //int num2 = -2;
            //int num3 = -6;
            //int num4 = 0;
            //int num5 = -1;

            //int max1 = Math.Max(num1, num2);
            //int max2 = Math.Max(num3, num4);
            //int max3 = Math.Max(max1, max2);
            //int max = Math.Max(max3, num5);


            //Console.WriteLine($"The maximum number is: {max}");
            /////////////////////////////////////////////////////////////////
            //Console.Write("Input kilometers per hour: ");
            //double kmPerHour = Convert.ToDouble(Console.ReadLine());


            //double milesPerHour = kmPerHour * 0.621371;

            //Console.WriteLine($"{kmPerHour} kilometers per hour is equal to {milesPerHour} miles per hour.");

            //////////////////////////////////////////////////////////////////////////

            //Console.Write("Input hours: ");
            //int hours = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Input minutes: ");
            //int minutes = Convert.ToInt32(Console.ReadLine());


            //int totalMinutes = hours * 60 + minutes;


            //Console.WriteLine($"Total: {totalMinutes} minutes.");

            /////////////////////////////////////////////////////////////////////////


            //Console.Write("Input minutes: ");
            //int totalMinutes = Convert.ToInt32(Console.ReadLine());


            //int hours = totalMinutes / 60;
            //int remainingMinutes = totalMinutes % 60;
            //Console.WriteLine($"{hours} Hours, {remainingMinutes} Minutes");

            ///////////////////////////////////////////////////////////////////////////////////////

           
            string a = "Burger and fries are the greatist invintion ever";
            string b = "I love cats";
            string c = "The sky is blue.";
            string d = "who are you?";
            string e = "I dont love cats";

            Console.WriteLine(a.PadLeft(25, '-'));
            Console.WriteLine(b.PadLeft(25, '-'));
            Console.WriteLine(c.PadLeft(25, '-'));
            Console.WriteLine(d.PadLeft(25, '-'));
            Console.WriteLine(e.PadLeft(25, '-'));
            Console.ReadKey();
        }
    }
}
