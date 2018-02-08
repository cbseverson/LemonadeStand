using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        public string Monday;
        public string Tuesday;
        public string Wednesday;
        public string Thursday;
        public string Friday;
        public string Saturday;
        public string Sunday;


        public void DisplayWeather()
        {
            //display the forecast or actual?
        }
        public void forecast(int day)
        {
            switch (day){ 
          
                case 1:
                        Console.WriteLine("The weather on Monday is sunny and 80 degrees");
                break;
                case 2:
                    Console.WriteLine("The weather on Tuesday is rainy and 60 degrees");
                break;
                case 3:
                    Console.WriteLine("The weather on Wednesday is sunny and 60 degrees");
                break;
                case 4:
                    Console.WriteLine("The weather on Thursday is sunny and 90 degrees");
                break;
                case 5:
                    Console.WriteLine("The weather on Friday is rainy and 70 degrees");
                    break;
                case 6:
                    Console.WriteLine("The weather on Saturday is overcast and 80 degrees");
                break;
                case 7:
                    Console.WriteLine("The weather on Sunday is sunny and 70 degrees");
                break;
            }
        }

        public void actualWeather()
        {
            //link to an API 
        }
    }
}
