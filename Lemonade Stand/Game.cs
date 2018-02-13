using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {
        Player player;
        Store store;
        Inventory inventory;
        Customer customer;
        UserInterface Ui = new UserInterface();

        public void RunGame()
        {
            player = Ui.userStartsGame();
            store = new Store(player);
            for(int i = 1; i < player.GetDays(); i++)
            {
                Day day = new Day();
                day.weather.DisplayWeather();
                Player.CostPerCup();
                //user decides what to charge per cup - player class? 
                Inventory.RemainingInventory();
                //user decides what to purchase in inventory - store class? 
                Customer.CustomerCups();
                //weather determines how many cups are sold - customer class, depends on customer preference
                //user learns how many cups they sold - profit/loss - player class
                //user learns how much inventory they have left - inventory class
            }
        }
    }
}
