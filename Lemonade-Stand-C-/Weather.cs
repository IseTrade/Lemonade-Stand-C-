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
     // This system divdes temperature and weather condition into 3 categories each.  2 Lists of 7 items each (for temperature and overcast condition) would be 
     // created via a randomizer.  The list indices from each list are paired with the other one to create a 7 day forecast.  This 7 day forecast is then randomized
     // to produce a daily forecast.  At least that's the idea...
        public int temperatureIndex;
        public int conditionIndex;
        public int weatherIndex;
        public List<int> weekTempList = new List<int>();
        public List<int> weekCondList = new List<int>();
        public List<string> temperatureList = new List<string>()   // Creating a 3 item list for temperature
        
        {
            "Cold",
            "Warm",
            "Hot"
        };

        public List<string> conditionList = new List<string>()  // Creating a 3 item list for overcast condition
        {
            "Rainy",
            "Overcast",
            "Sunny"
        };

        public Weather()
        {
            int weatherIndex = GetWeatherIndex(temperatureIndex, conditionIndex);
        }
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

        public void ShowWeekForecast()    //Creating the 7 day forecast by putting the two randomized lists together.
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
        public int GetWeatherIndex(int tempIndex, int condIndex)    // This weatherIndex score is important in determining the number of potential customers on a given day.
        {
            int wIndex = temperatureIndex + conditionIndex;
            return wIndex;
        }
    }
}