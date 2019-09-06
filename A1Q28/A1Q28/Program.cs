using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the joining year of the employee : ");
            int jyear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the current year : ");
            int cyear = Convert.ToInt32(Console.ReadLine());
            if(cyear-jyear>3)
            {
                Console.WriteLine("Bonus of 2500/- should be given to the employee");

            }

            Console.ReadLine();
        }
    }
}
