using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q21
{
    class Q21
    {
        static void Main(string[] args)
        {
            int errorCounter = 0;

            for (int i = 0; i < 1800; i++)
            {
                Console.Write((i+1)+") Enter the student ID : ");
                string ID = Console.ReadLine();

                Console.Write("Enter the day " + ID + " joined  (in numbers format)");
                int jday = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the month " + ID + " joined (in numbers format)");
                int jmonth = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the year " + ID + " joined (in numbers format)");
                int jyear = Convert.ToInt32(Console.ReadLine());

                jyear = jyear % 100;


                Console.Write("Enter the day " + ID + " left  (in numbers format)");
                int lday = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the month " + ID + " left (in numbers format)");
                int lmonth = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the year " + ID + " left (in numbers format)");
                int lyear = Convert.ToInt32(Console.ReadLine());

                lyear = lyear % 100;

                if (lyear < jyear)
                {

                    errorCounter ++;
                }
                else if (lyear == jyear)
                {
                    if (lmonth < jmonth)
                    {

                        errorCounter++;
                    }
                    else if(lmonth==jmonth)
                    {
                        if (lday < jday)
                        {
                            errorCounter++;
                        }
                    }
                }

                Console.WriteLine("The errors occured yet are : " + errorCounter);
            }
            Console.WriteLine("The total errors occured are : "+errorCounter);

            Console.ReadLine();
        }
    }
}
