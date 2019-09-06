using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q13
{
    class Q13
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write the name of the country  Daniel trevels to from Italy from the below list : ");
            Console.WriteLine("");
            Console.WriteLine("COUNTRY (make sure the name of the country is added as it is written below)");
            Console.WriteLine("Mexico");
            Console.WriteLine("India");
            Console.WriteLine("New Zealand");
            Console.WriteLine("");
            string c = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Enter the hour it is in Italy :");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the minute it is in Italy :");
            int m = Convert.ToInt32(Console.ReadLine());

            if (c != "New Zealand")
            {

                if (c != "India")
                {

                    if (h > 24 || h < 0 || m > 60 || m < 0 || c != "Mexico")
                    {
                        Console.WriteLine("Make sure you have given a valid values");
                        Console.WriteLine("Write the name of the country  Daniel trevels to from Italy from the below list : ");
                        Console.WriteLine("");
                        Console.WriteLine("COUNTRY (make sure the name of the country is added as it is written below)");
                        Console.WriteLine("Mexico");
                        Console.WriteLine("India");
                        Console.WriteLine("New Zealand");
                        c = Console.ReadLine();
                        Console.WriteLine("Enter the hour it is in Italy :");
                        h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the minute it is in Italy :");
                        m = Convert.ToInt32(Console.ReadLine());

                    }
                }
            }
            if (c == "Mexico" || c == "mexico")
            {
                h = h - 7;
                if (h < 0)
                {
                    h = h + 24;
                }
                Console.WriteLine("The time in Mexico is " + h + ":" + m);
            }
            else if (c == "India" || c == "india")
            {
                h = h + 4;
                m = m + 30;
                if (m > 59)
                {
                    m = m - 60;
                    h = h + 1;

                }
                if (h > 24)
                {
                    h = h - 24;
                }

                Console.WriteLine("The time in India is " + h + ":" + m);
            }
            else if (c == "New Zealand")
            {
                h = h + 11;


                if (h > 24)
                {
                    h = h - 24;
                }

                Console.WriteLine("The time in New Zealand is " + h + ":" + m);
            }









            Console.ReadLine();

        }
    }
}
