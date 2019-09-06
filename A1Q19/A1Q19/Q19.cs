using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q19
{
    class Program
    {
        static void Main(string[] args)
        {

            int greaterThan100 = 0;
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine((i + 1) + ") Enter a number : ");
                double number = Convert.ToDouble(Console.ReadLine());

                if (number > 100)
                {
                    greaterThan100 ++;
                }
            }

            Console.WriteLine("The numbers greater than 100 are : " + greaterThan100);
            Console.ReadLine();

        }
    }
}
