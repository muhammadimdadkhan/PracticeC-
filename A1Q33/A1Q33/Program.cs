using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the days the book was returned late : ");
            int days = Convert.ToInt32(Console.ReadLine());
            int fine = 0;
            if (days > 30)
            {
                Console.WriteLine("Your membership has been cancelled.");

            }
            else if (days > 10)
            {
                fine = 5;
                Console.WriteLine(fine + " rupee fine must be taken.");

            }
            else if (days > 5)
            {
                fine = 1; 
                Console.WriteLine(fine + " rupee fine must be taken.");

            }
            else if (days > 0)
            {
                fine = 50;
                Console.WriteLine(fine + " paise fine must be taken.");

            }
            else
            {
                Console.WriteLine("No fine must be taken");
            }

            Console.ReadLine();
        }
    }
}
