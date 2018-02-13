using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        public int Temperature;
        public string weather;
        Random random = new Random(); 


        public void DisplayWeather()
        {
            UserInterface.userForecastDate();
            //display the forecast or actual?
        }
        public void forecast(int day)
        {
            var choice = random.Next() * 100;
            if (choice > 20)
            {
                Temperature = 50;
                weather = "Sunny";
            }
            else if (choice > 40)
            {
                Temperature = 60;
                weather = "Sunny";
            }
            else if (choice > 60)
            {
                Temperature = 70;
                weather = "Rain";
            }
            else if (choice > 80)
            {
                Temperature = 60;
                weather = "Rain";
            }
            else if (choice <= 100)
            {
                Temperature = 80;
                weather = "Sunny";
            }
        }

        public void actualWeather(int day)
        {
            var actual = random.Next() * 100;
            if (actual > 15)
            {

            }
            else if (actual > 30)
            {

            }
            else if (actual > 50)
            {

            }
        }
    }
}
