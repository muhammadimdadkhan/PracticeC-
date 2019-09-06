using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q8
{
    class Q8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a four digit number : ");
            int d = Convert.ToInt32(Console.ReadLine());

            while (d > 9999||d<1000)
            {
                Console.WriteLine("Enter a FOUR digit number : ");
                d = Convert.ToInt32(Console.ReadLine());
            }
            
            Int32 first = d / 1000;

            Int32 last = d % 10;
            Int32 sum = first + last;


            Console.Write("The sum of the five digit number is : " + sum);


            Console.ReadLine();

        }
    }
}
