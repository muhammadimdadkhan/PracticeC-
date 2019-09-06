using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q18
{
    class Q18
    {
        static void Main(string[] args)
        {
            int dailyLimit = 100000;
            int widthrawal = 0;
            Console.WriteLine("Enter the current balance in your account : ");
            double currentBalance = Convert.ToDouble (Console.ReadLine());
            for (int i = 0;i<1;i++)
            {
            
            Console.WriteLine("Enter the amount you want to widthraw from your account : ");
            widthrawal = Convert.ToInt32(Console.ReadLine());

            if (currentBalance < widthrawal)
            {

                i --;
                Console.WriteLine("You don't have enough balance in yuor account ");

            }
            else if (dailyLimit<widthrawal)
            {
                i --;
                Console.WriteLine("You have reached your daily limit ");


            }

                if (widthrawal < dailyLimit && widthrawal < currentBalance)
            {
                Console.WriteLine("You had " + currentBalance + "$ in your account");
                currentBalance = currentBalance - widthrawal;
                


                if (currentBalance < 5000)
                {
                    currentBalance = currentBalance - currentBalance * 0.02;
                }
            }

            
            }
            if (currentBalance < 5000)
            {
                Console.WriteLine("since you have current Balance is less than 5000$ a 2% charge was made");
            }

            Console.WriteLine("You have widthrawn " + widthrawal + "$ ");
            Console.Write("Now you have " + currentBalance + "$ in your account");

            Console.ReadLine();
        }

    }
}
