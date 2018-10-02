using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    //Inherit from our common methods
    public class Weather : Common
    {
        
        public int temperatureIndex;
        public int conditionIndex;
        //public int weatherIndex;
        public int weatherIndex = GetWeatherIndex(temperatureIndex, conditionIndex);
        public List<int> weekTempList = new List<int>();
        public List<int> weekCondList = new List<int>();
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

        public List<int> GetWeekTempList()
        {
            for (int i = 0; i < 7; i++)
            {
                int temperatureIndex = GetRandom(0, 3);
                weekTempList.Add(temperatureIndex);
            }
            return weekTempList;
        }

        //randomize condition list
        public List<int> GetWeekConditionList()
        {
            for (int i = 0; i < 7; i++)
            {
                int conditionIndex = GetRandom(0, 3);
                weekCondList.Add(conditionIndex);
            }
            return weekCondList;
        }


        public void ShowWeekForecast()
        {
            weekTempList = GetWeekTempList();
            weekCondList = GetWeekConditionList();
            Console.WriteLine("The week forecast are as follows: ");
            for (int i = 0, j = 0; i < 7; i++, j++)
            {
                string temp = temperatureList[weekTempList[i]];
                string cond = conditionList[weekTempList[i]];
                Console.WriteLine("Day {0} {1} and {2}.", j, temp, cond);
            }
        }

        public void ShowCurrentWeather()
        {
            int x = GetRandom(0, 6);
            temperatureIndex = weekTempList[x];
            conditionIndex = weekCondList[x];
            Console.WriteLine("The current weather is {0} and {1}.", temperatureList[temperatureIndex], conditionList[conditionIndex]);
        }
        public int GetWeatherIndex(int tempIndex, int condIndex)
        {
            int wIndex = temperatureIndex + conditionIndex;
            return wIndex;
        }
    }
}