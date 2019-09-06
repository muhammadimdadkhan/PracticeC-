using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q32
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter first side of the triangle : ");
            double firstSide = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second side of the triangle : ");
            double secondSide = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third side of the triangle : ");
            double thirdSide = Convert.ToDouble(Console.ReadLine());

            if (firstSide + secondSide + thirdSide == 180)
            {
                Console.WriteLine("The triangle is valid");
            }
            else
            {
                Console.WriteLine("The triangle is invalid");
            }

            Console.ReadLine();
        }
    }
}
