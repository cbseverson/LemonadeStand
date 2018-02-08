using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {
 
        public void RunGame()
        {
            int numberOfDays = GetDays();
            for(int i = 1; i < numberOfDays; i++)
            {
                Day day = new Day();
                day.weather.DisplayWeather();
                Player player = new Player();
                //user decides what to charge per cup - player class? 

                //user decides what to purchase in inventory - player class? 
                //weather determines how many cups are sold - customer class, depends on customer preference
                //price of the product changes how many people purchase - which class? 
                //user learns how many cups they sold - profit/loss - player class
                //user learns how much inventory they have left - inventory class

                //game loops based on days decided - should user decide that in user interface? 
            }
        }
    }
}
