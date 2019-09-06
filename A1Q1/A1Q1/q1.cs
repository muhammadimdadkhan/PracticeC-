using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q1
{
    class q1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your basic salary : ");
            int bs = Convert.ToInt32(Console.ReadLine());

            double da = bs * 0.4;
            double hr = bs * 0.2;
            double gs = bs + da + hr;

            Console.WriteLine("Your dearness allowancs are : " + da);
            Console.WriteLine("Your house rent allowancs are : " + hr);
            Console.WriteLine("Your gross salary is : " + gs);
            Console.ReadLine();
             
           


        }
    }
}
