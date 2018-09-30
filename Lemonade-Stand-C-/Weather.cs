using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    public class Weather
    {
        public int weatherIndex;
        public double weatherDemand;
        public Random rnd;
        public Weather()
        {
            //default constructor
        }


        public List<string> temperatureList = new List<string>()
        {
            "Cold",
            "Warm",
            "Hot"
        };

        public List<string> conditionList = new List<string>()
        {
            "Rainy",
            "Overcast",
            "Sunny"
        };
        public void GetWeekForecast(Random rnd)
        {

        }
        //Randomizer
        //public int Randomizer()
        //{
        //    Random rnd = new Random();
        //    public int rand = rnd.Next(0, 3);
        //    return rand;
        //}

        //randomize temperature list
        public int GetRandomTemp()
        {
            Random rnd = new Random();
            int temperatureIndex = rnd.Next(0, 3);
            return temperatureIndex;
        }

        //randomize condition list
        public int GetRandomCondition()
        {
            Random rnd = new Random();
            int conditionIndex = rnd.Next(0, 3);
            return conditionIndex;
        }

        public void DayForecast()
        {
            Console.WriteLine("The forecast for today is {0} and {1}.", temperatureList[GetRandomTemp()], conditionList[GetRandomCondition()]);
        }


        public void TodayWeather()
        {

        }

        public int WeatherIndex() //score 0-4, with 4 being the best weather and temperature
        {
            return weatherIndex = GetRandomCondition() + GetRandomTemp();
        }
        public double GetWeatherDemand()
        {
            if (weatherIndex == 4)
            {
                weatherDemand = 0.90;
            }
            else if (weatherIndex == 3)
            {
                weatherDemand = 0.70;
            }
            else if (weatherIndex == 2)
            {
                weatherDemand = 0.50;
            }
            else if (weatherIndex == 1)
            {
                weatherDemand = 0.30;
            }
            else if (weatherIndex == 0)
            {
                weatherDemand = 0.10;
            }           
            return weatherDemand;
        }

    }
}
