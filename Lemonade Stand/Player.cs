using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
        public Wallet wallet;
        public Inventory inventory;
        public Player()
        {
            wallet = new Wallet();
            inventory = new Inventory();
        }
        public void PlayerName()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
        }
        
        public int GetDays()
        {
            Console.WriteLine("How many days would you like to play? Enter a number from 1 to 7");
            string getDays = Console.ReadLine();
            try
            {
                return int.Parse(getDays);
            }
            catch (Exception)
            {
                Console.WriteLine("You didn't enter a number, try again");
                return GetDays();
            }
        }

        public int CostPerCup()
        {
            Console.WriteLine("How much do you want to charge per cup? Enter a number");
            string getCost = Console.ReadLine();
            try
            {
                return int.Parse(getCost);
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a number without any $ signs");
                return CostPerCup();
            }
        }

        public void PlayerProfitInformation()
        {
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
