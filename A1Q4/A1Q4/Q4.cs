using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q4
{
    class Q4
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter temperature of the city in Fahrenheit : ");
            double F = Convert.ToDouble(Console.ReadLine());
            double C = 5 / (F - 32);
            Console.WriteLine("The temperature of the city in Centigrade is : " + C);




            Console.ReadLine();

        }
    }
}
