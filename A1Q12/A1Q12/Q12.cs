using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q12
{
    class Q12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");

            int n = Convert.ToInt32(Console.ReadLine());
            while (n % 2 != 1 && n % 2 != 0 && n % 2 != -1)
            {
                Console.WriteLine("Enter a number in integer:");
                n = Convert.ToInt32(Console.ReadLine());
            }

            if (n % 2 == 1 || n % 2 == -1)
            {
                Console.WriteLine("The number you entered is an odd number");
            }
            else if (n % 2 == 0)
            {
                Console.WriteLine("The number you entered is an even number");
            }
            Console.ReadLine();
        }
    }
}
