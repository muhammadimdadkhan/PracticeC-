using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance between the two cities (in Kilometers) : ");
            double d = Convert.ToDouble(Console.ReadLine());

            double m = d * 1000;
            double f = d * 3280.8399;
            double i = d * 38370.078;
            double cm = d * 100000;

            Console.WriteLine("The distance in meters : " + m);
            Console.WriteLine("The distance in feets : " + f);
            Console.WriteLine("The distance in inches : " + i);
            Console.WriteLine("The distance in centimeters : " + cm);
            Console.ReadLine();

        }
    }
}
