using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Q35
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double bpOfAShare = 21.77;
            double spOfAShare = 16.44;
            double bpOfTotalShare = 600 * 21.77;
            double spOfTotalShare = 600 * 16.44;
            double lostMoney = bpOfTotalShare - spOfTotalShare;
            int percentLoss =Convert.ToInt32( spOfAShare / bpOfAShare*100);

            Console.WriteLine("The total ammount paid for the stock : " + bpOfTotalShare);
            Console.WriteLine("The total ammount recieved from the stock : " + spOfTotalShare);
            Console.WriteLine("The total amount of money he lost : " + lostMoney);
            Console.WriteLine("He lost " + percentLoss +"% of his money");
            Console.ReadLine();






        }
    }
}
