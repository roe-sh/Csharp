using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using task4;

namespace task4
{
    internal class task
    {
        public static string ReturnSumAndAverage(params double[] grades)
        {
            double sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            };
            return $"the sum is: {sum} and the avarege is {sum / grades.Length}";
        }


        public static int GetYears(int[] years)
        {
            foreach (int year in years)
            {
                if (year > 1950)
                {
                    Console.WriteLine(year);
                }
            }
            return 0;
        }


        public static int CalculateAgeInDays(int years)
        {
            if (years <= 0)
            {
                Console.WriteLine("inter a valid age");
            }
            else
            {
                const int daysInYear = 365;
                Console.WriteLine($"the age in days is: {years * daysInYear}");
            }
            return 0;
        }

    }
}



    //Q5

    