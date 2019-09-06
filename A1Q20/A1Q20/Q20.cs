using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q20
{
    class Q20
    {
        static void Main(string[] args)
        {
            int i = 0;
            int digits = 1;

            Console.WriteLine("Enter a whole number greater than 0");
            int number = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < 1; i++)
            {
                
                if (number < 0)
                {
                    Console.WriteLine("Re-enter a whole number greater than 0");
                    number = Convert.ToInt32(Console.ReadLine());
                    i--;

                }
                
            }

            for (int numberForLoop = number; numberForLoop > 10; )
            {
                numberForLoop = numberForLoop / 10;

                digits ++;
            }
            Console.WriteLine("" + digits + "," + number);
            Console.ReadLine();

            
            
        }
    }
}
