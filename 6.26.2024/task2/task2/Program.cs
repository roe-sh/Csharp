﻿using System;
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

             //Console.WriteLine("2- The sign");
            //Console.WriteLine("Enter a number");
            //int n1 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("The sign of the number is: "+Math.Sign(n1));

            ///////////////////////////////////////////////////////////////////////
            ///
           //Console.WriteLine("3- sort numbers");
            //Console.WriteLine("Enter 3 numbers");
            //int a1=Convert.ToInt32(Console.ReadLine());
            //int b1=Convert.ToInt32(Console.ReadLine());
            //int c1=Convert.ToInt32(Console.ReadLine());
            //int[] nums ={ a1,b1,c1 };
            //Array.Sort(nums);
            //Array.Reverse(nums);
            //Console.WriteLine(String.Join(" ", nums));


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
