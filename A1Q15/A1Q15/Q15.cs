using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q15
{
    class Q15
    {
        static void Main(string[] args)
        {
            int cards = 0;
            int sweets = 0;
            int stationery = 0;
            int toy = 0;

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine((i + 1) + ") Enter the 3 digit code of the item : ");

                int code = Convert.ToInt32(Console.ReadLine());

                if (code < 400)
                {
                    int twoDigitCode = code / 10;
                    if (twoDigitCode < 10)
                    {
                        cards++;
                    }

                    else if (twoDigitCode < 20)
                    {
                        sweets++;
                    }
                    else if (twoDigitCode < 30)
                    {
                        stationery ++;
                    }
                    else if (twoDigitCode < 40)
                    {
                        toy++;
                    }

                }
                else
                {
                    i = i--;
                }
            }

            Console.WriteLine("The number of cards sold are : " + cards);
            Console.WriteLine("The number of sweets sold are : " + sweets);
            Console.WriteLine("The number of stationeries sold are : " + stationery);
            Console.WriteLine("The number of toys sold are : " + toy);

            Console.ReadLine();

        }
    }
}
