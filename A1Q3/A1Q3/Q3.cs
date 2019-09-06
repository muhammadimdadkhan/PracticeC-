using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q3
{
    class Q3
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Enter marks of English :");
            
            double eng = Convert.ToDouble (Console.ReadLine());
            while (eng > 100)
            {
                Console.WriteLine("Enter marks of English below or equal to 100 : ");
                 eng = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter marks of Urdu :");
            double urdu = Convert.ToDouble(Console.ReadLine());
            while (urdu > 100)
            {
                Console.WriteLine("Enter marks of Urdu below or equal to 100 : ");
                urdu = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter marks of Math :");
            double math = Convert.ToDouble(Console.ReadLine());
            while (math > 100)
            {
                Console.WriteLine("Enter marks of Maths below or equal to 100 : ");
                math = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Enter marks of Programming Fundamentals :");
            double PF = Convert.ToDouble(Console.ReadLine());
            while (PF > 100)
            {
                Console.WriteLine("Enter marks of Programming Fundamentals below or equal to 100 : ");
                PF = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter marks of Pakistan and Islamic Studies  :");
            double PIS = Convert.ToDouble(Console.ReadLine());
            while (PIS > 100)
            {
                Console.WriteLine("Enter marks of Pakistan and Islamic Studies below or equal to 100 : ");
                PIS = Convert.ToDouble(Console.ReadLine());
            }


            double total = (eng + math + PIS + PF + urdu)/5;

            Console.WriteLine("The percentage obtained by the candiate is " + total + "%");




            Console.ReadLine();


        }
    }
}
