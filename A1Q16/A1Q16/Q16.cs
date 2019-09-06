using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q16
{
    class Program
    {
        static void Main(string[] args)
        {

            double lowestTemp = 0;
            int temp20 = 0;
            int temp10 = 0;
            for (int i = 0; i < 200; i++)
            {
                
                Console.WriteLine((i + 1) + ") Enter the temperature collected (°C) : ");
                double temp = Convert.ToDouble(Console.ReadLine());
                for (int j = 0; j == 0; j++)
                {
                    lowestTemp = temp;
                }
                if (temp > 20)
                {
                    temp20 ++;

                }
                else if (temp < 10)
                {
                    temp10 ++;
                }
                if (temp < lowestTemp)
                {
                    lowestTemp = temp;
                }
            }
            Console.WriteLine("The temperatures above 20 °C are : " + temp20);
            Console.WriteLine("The temperatures below 10 °C are : " + temp10);
            Console.WriteLine("The lowest temperature of all temperature is : " + lowestTemp);
            Console.ReadLine();
            
        }
    }
}
