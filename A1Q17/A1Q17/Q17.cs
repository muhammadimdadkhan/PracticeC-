using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q17
{
    class Q17
    {
        static void Main(string[] args)
        {
            

            int CD = 0;
            int DVD = 0;
            int video = 0;
            int book = 0;
            

            for (int i = 0; i < 5000; i++)
            {

                Console.WriteLine((i + 1) + ") Enter the 5 digit code : ");

                int code = Convert.ToInt32(Console.ReadLine());

                if (code < 50000 && code > 9999)
                {
                    int firstDigit = code / 10000;
                    if (firstDigit == 1)
                    {
                        CD ++;
                        Console.WriteLine("It's a CD");
                    }

                    else if (firstDigit == 2)
                    {
                        DVD ++;
                        Console.WriteLine("It's a DVD");
                    }
                    else if (firstDigit == 3)
                    {
                        video ++;
                        Console.WriteLine("It's a video");
                    }
                    else if (firstDigit == 4)
                    {
                        book ++;
                        Console.WriteLine("It's a book");
                    }

                }
                else
                {
                    i = i - 1;
                    Console.WriteLine("It's not a valid code");
                }
            }

            Console.WriteLine("The number of stock in CD  are : " + CD);
            Console.WriteLine("The number of stock in DVD are : " + DVD);
            Console.WriteLine("The number of stock in videos are : " + video);
            Console.WriteLine("The number of stock in books are : " + book);

            Console.ReadLine();

        }
    }
}
