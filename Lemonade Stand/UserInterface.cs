using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class UserInterface
    {
        public void userStartsGame() {
            Console.WriteLine("Welcome to the Lemonade Stand: Open your own and try to make a profit. Your customers will purchase based on taste, weather, and cost");
            Player player = new Player();
            player.GetDays();
            //forecast should be here
            player.CostPerCup();

        }

        public void userForecastDate() {
            Console.WriteLine("Today is BLANK and the weather forecast is BLANK");
        }

        public void userPurchase() {
            Console.WriteLine("How many lemons do you want to buy? /n They cost $0.50 each");
            Console.WriteLine("How many ice cubes do you want to buy? /n A bag of 100 costs $2.00");
            Console.WriteLine("How many cups do you want to buy? /n A package of 25 costs $3.00");
            Console.WriteLine("How much sugar do you want to buy? /n Each bag costs $1.00");
        }

        public void userRemainingInventory()
        {
            Console.WriteLine("You have BLANK lemons remaining");
            Console.WriteLine("You have BLANK ice cubes remaining");
            Console.WriteLine("You have BLANK cups remaining");
            Console.WriteLine("You have BLANK sugar remaining");

        }

        
    }
}
