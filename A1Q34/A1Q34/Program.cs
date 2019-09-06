using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first side of the triangle : ");
            int firstSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second side of the triangle : ");
            int secondSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third side of the triangle : ");
            int thirdSide = Convert.ToInt32(Console.ReadLine());

            if(firstSide==secondSide&&secondSide==thirdSide)
            {
                Console.WriteLine("It is an equilateral triangle");
        
            }
            else if (firstSide != secondSide && secondSide != thirdSide && thirdSide != firstSide)
            {
                Console.WriteLine("It is an isosceles triangle ");
        
            }
            
            else
            {
                Console.WriteLine("It is a scalene triangle ");


            }

            Console.ReadLine();
        }
    }
}
