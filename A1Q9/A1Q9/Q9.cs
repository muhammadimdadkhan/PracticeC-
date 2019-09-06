using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q9
{
    class Q9
    {
        static void Main(string[] args)
        {

            int p = 80000;
            double m = p * 0.52;
            double tl = p * 0.48;
            double tlm = p * 0.35;
            double tlw = tl - tlm;

            Console.WriteLine("The total number of literate men are : " + tlm);
            Console.WriteLine("The total number of literate women are : " + tlw);

            Console.ReadLine();
        }
    }
}
