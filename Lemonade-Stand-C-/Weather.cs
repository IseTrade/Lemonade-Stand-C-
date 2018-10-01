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
        public int temperatureIndex;
        public int conditionIndex;
        //public List<int> weekTemplist;
        //public List<int> weekCondList;
        public static Random rand = new Random();

        public List<int> weekTempList = new List<int> ();
        public List<int> weekCondList = new List<int> ();
        public List<string> temperatureList = new List<string> ()
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

        public List<int> GetWeekTempList()
        {
            for (int i = 0; i < 7; i++)
            {
                //Random rnd = new Random();
                int temperatureIndex = rand.Next(0, 3);
                weekTempList.Add(temperatureIndex);
            }    
            return weekTempList;
        }


        //randomize condition list
        public List<int> GetWeekConditionList()
        {
            for (int i = 0; i < 7; i++)
            {
                //Random rnd = new Random();
                int conditionIndex = rand.Next(0, 3);
                weekCondList.Add(conditionIndex);
            }
            return weekCondList;
        }
        //public void GetWeekForecast()
        //{
            // The weekly forecast is taken from weekTemList and weekCondList
            // then each list is then randomized and element [0] is used to determine currently weather.
        //}
        //public void GetTodayWeather()
        //{
            // The weekly forecast is taken from weekTemList and weekCondList
            // then each list is then randomized and element [0] is used to determine currently weather.
        //}
        public void ShowWeekForecast()
        {
            Console.WriteLine("The forecast for next 7 days are as follows: ");
            for (int i = 0; i < 7; i++)
            {
                string x = temperatureList[weekTempList[i]];
                string y = conditionList[weekTempList[i]];
                Console.WriteLine("Day {0}  {1} and {2}.", i+1, x,y);
            }           
        }
        public int ShowTodayWeather()
        {
            int x = rand.Next(0 - 7);
            int y = rand.Next(0 - 7);
            temperatureIndex = weekTempList[x];
            conditionIndex = weekCondList[y];                    
            Console.WriteLine("The current weather is {0} and {1}.", temperatureList[temperatureIndex], conditionList[conditionIndex]);
            return weatherIndex = temperatureIndex + conditionIndex;
        }

        //public int WeatherIndex() //score 0-4, with 4 being the best weather and temperature
        //{
        //    return weatherIndex = weekTempList[0] + weekCondList[0];
            // this is used in calculating customers demand probability due to weather. 
            
        //}
    }
}
