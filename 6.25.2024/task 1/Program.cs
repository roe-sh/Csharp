using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name : ");
            string myName = Console.ReadLine();
            Console.WriteLine(myName);

            Console.ReadKey();
        }
    }
}


namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double avg = 5.2;
            String name = "hadeel";
            Char one = 'a';
            bool correct = false;
            int number = 0;
            const int sum = 33;
            Console.WriteLine(name);
            Console.WriteLine(avg);
            Console.WriteLine(one);
            Console.WriteLine(correct);
            Console.WriteLine(number);
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}




namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "opel", "Toyota", "Mercedess", "Nissan", "Volvo", "Mazda" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[3]);
            Console.WriteLine(cars[4]);
            Console.WriteLine(cars[5]);

            Console.WriteLine("The Length Of array is : ");
            Console.WriteLine(cars.Length);

            Console.ReadKey();
        }
    }
}







namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your First Name  :  ");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name  :  ");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter Your BirthDay  :  ");
            int birthday = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(fName + " " + lName + " " + birthday);

            Console.ReadKey();
        }
    }
}




namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter Length Of Array  :  ");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[count];
            int[] number = new int[count];
            for (int i = 0; i < count; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                number[i] = num;
                numbers[i] = number[i];
            }

            Console.WriteLine("Array : ");
            Array.Sort(numbers);
            Console.WriteLine(string.Join(" - ", numbers));


            Console.ReadKey();
        }
    }
}




namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Index in Array : ");

            int num = Convert.ToInt32(Console.ReadLine());
            //int element;
            int sum = 0;
            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("The Sum Of the Element Is :  ");
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
