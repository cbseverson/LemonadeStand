using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Wallet
    {   double balance;
        double netProfit;
        double initialBalance;

        public Wallet()
        {
            balance = 20;
            initialBalance = 20;
        }

        public bool GetBalance(double amount)
            {
            if ((balance - amount) > 0)
            {
                balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, you can't purchase any more items.");
                return false;
            }
        }
        public double GetNetProfit()
        {
            return balance - initialBalance;
        }
    }
}

