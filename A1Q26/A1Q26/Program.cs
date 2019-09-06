using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q26
{
    class Program
    {
        static void Main(string[] args)
        {


            int D1 = 0;
            int D2 = 0;
            int D3 = 0;
            int D4 = 0;
            int i = 0;
            int number = 0;
            

            for (i = 0; i < 5000; i++)
            {
                if (number / 1000 < 10)
                {
                    Console.Write((i + 1) + ") ");
                }

                Console.WriteLine("Enter a number in a range of 1-4 digits");
                number = Convert.ToInt32(Console.ReadLine());
                if (number / 1000 >= 10)
                {
                    Console.Write((i+1) + ") ");
                    i--;
                    Console.Write("Re-");
                }
                else if (number / 1000 >= 1)
                {
                    D4++;

                }
                else if (number / 100 >= 1)
                {
                    D3++;

                }
                else if ((number / 10) >= 1)
                {
                    D2++;

                }
                else if (number >= 1)
                {
                    D1++;

                }
                else
                {
                    i--;
                }
            }
            
            Console.WriteLine("the total 1 digit numbers were : " + D1);
            Console.WriteLine("the total 2 digit numbers were : " + D2);
            Console.WriteLine("the total 3 digit numbers were : " + D3);
            Console.WriteLine("the total 4 digit numbers were : " + D4);
            
            Console.ReadLine();
        }
    
    }
}
