using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q24
{
    class Program
    {
        static void Main(string[] args)
        {

            int yodaFone=0;
            int N2Network=0;
            int koffeeMobile=0;
            int satsumaMobile=0;
            int other=0;

            int j=0;
            int threeDigitnum =0;
            int i = 0;
            Console.WriteLine((i+1)+") Enter the eight digit number : ");
            int number = Convert.ToInt32(Console.ReadLine());
           for (i=0;i<50000;i++)
            for (j=0; j<1;j++)
            {
                if(number<100000000&&number>9999999)
                {
                   threeDigitnum= number/10000;
                    if(threeDigitnum==444)
                    {
                        yodaFone++;
                    }
                    else if(threeDigitnum==555)
                    {
                        N2Network++;
                    }

                    else if(threeDigitnum==666)
                    {
                        koffeeMobile++;
                    }
                    else if(threeDigitnum==777)
                    {
                        satsumaMobile++;
                    }
                    else
                    {
                    other++;
                    }



                }
                else
                {
                    j--;
                }
                    Console.WriteLine("number of calls made by koffeeMobile are : "+koffeeMobile);
                    Console.WriteLine("number of calls made by yodafone are : " + yodaFone);
                    Console.WriteLine("number of calls made by n2network are "+N2Network);
                    Console.WriteLine("number of calls made by satsumamobile are "+satsumaMobile);
            }


        }
    }
}
