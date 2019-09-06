using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter radius of the circle: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double a = r * r * 3.14159;
            double c = 2 * r * 3.14159;
            Console.WriteLine("The area of the circle is: " + a);
            Console.WriteLine("The circumfarance of the circle is: " + c);
            Console.ReadLine();
        }
    }
}
