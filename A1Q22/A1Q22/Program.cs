using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q22
{
    class Program
    {
        static void Main(string[] args)
        {


            double i = 0;
            int number = 0;
            double palindrome = 0;

            for (i = 0; i < 5; i++)
            {


                Console.WriteLine((i + 1) + ") Enter a four digit number : ");


                number = Convert.ToInt32(Console.ReadLine());
                if (9999 > number && 999 < number)
                {
                    int firstDigit = number / 1000;
                    int secondDigit = number / 100 - (firstDigit * 10);
                    int thirdDigit = number / 10 - (firstDigit * 100 + secondDigit * 10);
                    int fourthDigit = number % 10;
                    if (firstDigit == fourthDigit && thirdDigit == secondDigit)
                    {
                        palindrome++;
                    }
                }

                else
                {
                    i--;
                }
            }

            double palindromepercent = (palindrome / i) * 100;
            Console.WriteLine("There were " + palindrome + " palindromes in these numbers");
            Console.WriteLine("the percentage of palindromes in these numbers is : " + palindromepercent + "%");
            Console.ReadLine();
        }
    }
}
