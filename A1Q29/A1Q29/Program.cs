using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marital status (married/unmarried) : ");
            string maritalStatus = Console.ReadLine();

            Console.WriteLine("Enter Gender (male/female) : ");
            string gender =Console.ReadLine();

            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (maritalStatus == "married")
            {
                Console.WriteLine("The driver is insured");

            }

            else if (maritalStatus == "unmarried" && age > 30)
            {
                Console.WriteLine("The driver is insured");

            }
            else if (maritalStatus == "unmarried" && age > 25 && gender == "Female")
            {
                Console.WriteLine("The driver is insured");

            }
            else
            {
                Console.WriteLine("not insured");
            }

            Console.ReadLine();

        }
    }
}
