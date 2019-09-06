using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q10
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the amount to be withdrawn : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int h = a / 100;
            int h1 = a % 100;
            int f = h1 / 50;
            int f1 = h1 % 50;
            int t = f1 / 10;
            int t1 = f1 % 10;

            Console.WriteLine("The total amount of notes of 100 to be given are : " + h);
            Console.WriteLine("The total amount of notes of 50 to be given are : " + f);
            Console.WriteLine("The total amount of notes of 10 to be given are : " + t);
            Console.WriteLine("The total amount of cash remaining is : " + t1);

            Console.ReadLine();

        }
    }
}
