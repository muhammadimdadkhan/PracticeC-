using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q30
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Please Enter The Cost Price");
            double cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the selling price");
            double selling = Convert.ToDouble(Console.ReadLine());
            double profit = selling - cost;
            if (profit > 0)
            {
                Console.WriteLine("Incurred Profit Of " + profit);
            }
            else if (profit < 0)
            {
                Console.WriteLine("No loss nor profit Incurred  ");
            }

            else
            {
                Console.WriteLine("No Profit and no Loss was made");
            }
            Console.ReadLine();
        }
    }
}
