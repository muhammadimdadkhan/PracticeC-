using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int year = Convert.ToInt32(Console.ReadLine());
            double leapyear = year % 4;
            if (leapyear == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Normal Year");
            }
            Console.ReadLine();
        }
    }
}
