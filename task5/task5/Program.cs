﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Car
    {
        public int Year { get; set; }
        public string Carmake { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }
        public string Platenumber { get; set; }
        public string Color { get; set; }

        // Constructor
        public Car(int year, string type, double price, string carmake, string color, string model, string platenumber)
        {
            Year = year;
            Type = type;
            Price = price;
            Carmake = carmake;
            Color = color;
            Model = model;
            Platenumber = platenumber;
        }

        public void Startengine()
        {
            Console.WriteLine("the car is ready to start");
        }

        public void Stoptengine()
        {
            Console.WriteLine("the car is dead");
        }
        public string Carinfo()
        {
            return $"The car is {Carmake} made in {Year} and its type {Type}. its price {Price}, model {Model} and its plate number is {Platenumber} and its color is {Color}.";
        }

    }
    public class BMW : Car
    {
        public BMW(int Year, string Type, double Price, string Carmake, string Color, string Model, string Platenumber)
            : base(Year, Type, Price, Carmake, Color, Model, Platenumber)
        {

            Carinfo();

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(1968, "cupe", 45000, " Dodge", "Black", " Charger", "27 -   1   ");
            Console.WriteLine(car.Carinfo());
            car.Startengine();
            car.Stoptengine();
            BMW bmw = new BMW(1983, "cupe", 5000, "BMW", "blue", "316(e21)", "14-18314");
            Console.WriteLine(bmw.Carinfo());
        }
    }

}