using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q27
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number of items purchased : ");
            int itemPurchased = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter price of the item : ");
            int itemPrice = Convert.ToInt32(Console.ReadLine());
            double totalprice=0;
            if (itemPurchased > 1000)
            {
                totalprice = itemPurchased * itemPrice - itemPurchased * itemPrice / 10;

            }
            else
            {
                totalprice = itemPurchased * itemPrice;
            }

            Console.WriteLine("The total bill is : "+totalprice);
            Console.ReadLine();

        }
    }
}
