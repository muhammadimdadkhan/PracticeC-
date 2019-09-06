using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q25
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the temperature (°C) of the greenhouse : ");
            int temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Oxygen levels of the greenhouse : ");
            double oxygenlevels = Convert.ToDouble(Console.ReadLine());

            if (temp > 45)
            {
                Console.WriteLine("WARNING! \a Temperature is above 45°C ");

            }

            if (oxygenlevels < 0.19)
            {

                Console.WriteLine("WARNING! \a Oxygen level is below 0.19 ");
            }


            Console.ReadLine();

        }
    }
}
