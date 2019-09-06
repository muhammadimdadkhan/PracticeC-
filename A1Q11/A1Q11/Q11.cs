using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q11
{
    class Q11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the selling price of the 15 items : ");
            double sp15 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the profit of the 15 items : ");
            double p15 = Convert.ToDouble(Console.ReadLine());
            double sp = sp15 / 15;
            double p = p15 / 15;
            double cp = sp-p;
            Console.WriteLine("Cost price of 1 item is : " + cp);
            Console.ReadLine();

        }
    }
}
