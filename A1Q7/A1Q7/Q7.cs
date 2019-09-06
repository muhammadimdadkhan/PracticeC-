using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q7
{
    class Q7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a five digit number : ");
            int d = Convert.ToInt32(Console.ReadLine());

            while (d > 99999||d<0)
            {
                Console.WriteLine("Enter a FIVE digit number : ");
                d = Convert.ToInt32(Console.ReadLine());
            }
            

            Int32 first = d / 10000;

            Int32 second = (d / 1000) - (10 * first);
            Int32 third = (d / 100) - (100 * first) - (10 * second);
            Int32 fourth = (d / 10) - (1000 * first) - (100 * second) - (10 * third);
            Int32 fifth = d % 10;
            Int32 sum = first + second + third + fourth + fifth;


            Console.Write("The sum of the five digit number is :" + sum);


            Console.ReadLine();
        }
    }
}
