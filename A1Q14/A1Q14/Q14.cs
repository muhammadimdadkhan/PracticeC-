using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q14
{
    class Q14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of the vehicle (from th below list)");
            Console.WriteLine("");
            Console.WriteLine("car");
            Console.WriteLine("bus");
            Console.WriteLine("bike");
            Console.WriteLine("other");


            int car = 0;
            int bus = 0;
            int bike = 0;
            int other = 0;
            for (int i = 1; i <= 10000; i++)
            {


                Console.Write("" + i + ")");

                string vehicle = Console.ReadLine();
                Console.WriteLine("");

                if (vehicle == "car")
                {
                    car = car + 1;
                }
                else if (vehicle == "bus")
                {
                    bus = bus + 1;
                }
                else if (vehicle == "bike")
                {
                    bike = bike + 1;
                }
                else
                {
                    other = other + 1;
                }

            }

            Console.WriteLine("the number of cars passed the road junctions are " + car);
            Console.WriteLine("the number of bus passed the road junctions are " + bus);
            Console.WriteLine("the number of bike passed the road junctions are " + bike);
            Console.WriteLine("the number of vehicles passed the road junction that were");
            Console.WriteLine("not cars ,busses or bikes are " + other);

            Console.ReadLine();

        }
    }
}
