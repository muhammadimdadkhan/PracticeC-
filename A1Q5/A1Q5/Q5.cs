using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of the rectangle : ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter breadth of the rectangle : ");
            double b = Convert.ToDouble(Console.ReadLine());
            double a = b * l;
            double p = 2 * (b + l);
            Console.WriteLine("The area of the rectangle is : " + a);
            Console.WriteLine("The perameter of the rectangle is : " + p);

        }
    }
}
