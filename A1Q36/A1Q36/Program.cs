using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q36
{
    class Program
    {
        static void Main(string[] args)
        {
            double mealprice = 44.5;
            double tax = Convert.ToInt32(mealprice / 100 * 6.75);
            double mealPriceIncludingTax = Convert.ToInt32(mealprice + tax);
            double tip = Convert.ToInt32(mealPriceIncludingTax / 100 * 15);
            double total = Convert.ToInt32(mealPriceIncludingTax + tip);
            Console.WriteLine("meal cost : "+mealprice);

            Console.WriteLine("tax amount : "+tax);
            
            Console.WriteLine("tip amount : "+tip);

            Console.WriteLine("total bill : "+total);
            Console.ReadLine();

        }
    }
}
