using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
        public void PlayerName()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
        }
        
        public void GetDays()
        {
            Console.WriteLine("How many days would you like to play? Enter a number from 1 to 7");
            string getDays = Console.ReadLine();
            //do I need to convert from string to number?
        }

        public void CostPerCup()
        {
            Console.WriteLine("How much do you want to charge per cup? Enter a number");
            Console.ReadLine();
        }

        public void PlayerProfitInformation()
        {
            //need to subtract cost of inventory from initial dollar value - $20?
            //need to add in number of cups sold - customers? 
            //multiply cups by user choice of cost per cup
            //add profit plus loss
        }

        public void RemainingInventory()
        {
            //or should you just call 
        }
        

        
    }
}
