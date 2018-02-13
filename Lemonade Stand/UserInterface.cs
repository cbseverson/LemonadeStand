using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class UserInterface
    {
        public Player userStartsGame() {
            Console.WriteLine("Welcome to the Lemonade Stand: Open your own and try to make a profit. Your customers will purchase based on taste, weather, and cost");
            Player player = new Player();
            player.GetDays();
            Weather weather = new Weather();
            weather.DisplayWeather();
            player.CostPerCup();
            return player;
        }

        static public void userForecastDate(int temp, string weather) {
            Console.WriteLine($"The forecast is {temp} degrees and {weather}");
        }

        static public string userPurchase(Items item) {
            Console.WriteLine($"How many {item.names} do you want to buy? /n They cost {item.GetCost()} each");
            return Console.ReadLine();
        }

        static public void userRemainingInventory(int lemon, int sugar, int ice, int cup)
        {
            Console.WriteLine($"You have {lemon} lemons remaining");
            Console.WriteLine($"You have {ice} ice cubes remaining");
            Console.WriteLine($"You have {cup} cups remaining");
            Console.WriteLine($"You have {sugar} sugar remaining");

        }
        public void userProfitLoss()
        {
            Console.WriteLine("You made BLANK today. Your total profit so far is BLANK");
        }       
    }
}
