using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q23
{
    class Program
    {
        static void Main(string[] args)
        {

            int correct = 0;
            int i = 0;
            for (i = 0; i < 100; i++)
            {
                
                Console.WriteLine((i+1)+") Enter 5 digit code : ");
                double code = Convert.ToDouble(Console.ReadLine());
                if (code < 100000 && code > 9999)
                {
                    double code5 = code % 10;
                    double code4 = ((code % 100) - code5) / 10;
                    double code3 = ((code % 1000) - (code % 100)) / 100;
                    double code2 = ((code % 10000) - (code % 1000)) / 1000;
                    double code1 = code / 10000;

                    double code1a = code1 * 3;
                    double code3a = code3 * 3;
                    double code4a = code4 * 2;
                    double code2a = code2 * 2;
                    double sumCode = (code1a + code4a + code3a + code2a) % 10;
                    if (sumCode == code1)
                    {
                        correct ++;


                    }



                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine("the total barcodes enter correctly were : "+ correct);
            Console.ReadLine();

        }
    }
}
