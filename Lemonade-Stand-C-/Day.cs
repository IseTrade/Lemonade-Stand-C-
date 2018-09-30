using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    public class Day
    {
        public Weather weather;
        public int day;
        public List<Customer> customer;
        public double dayProfit;
        public double dayEarning;
        

        public Day()
        {
            day = 1;
            weather = new Weather();
            customer = new List<Customer>();

        }
        public void GetWeather(Random rnd)
        {

        }
        public void GetForecast(Random rnd)
        {

        }
        public void DisplayDay()
        {
            Console.WriteLine($"Today is Day {day}\n\n");

        }
         public void GetDayCustomers()
        {




        }
        public void DayCost()
        {
            double dayCost = 
        }
        public void GetDayRevenue()
        
            double dayRevenue = Player.soldLemonade * Inventory.lemonadePrice;
        }
        public void GetDayProfit()
        {
        double dayProfit = dayRevnue - store.supplyCost;

        }
        public void GetDayLoss()
        {
            dayLoss = day.SupplyCost - dayProfit; 
        }


        public void DisplayDayProfit()
        {
        if (dayProfit <= 0)
        {
            Console.WriteLine($"You lost money today! You lost ${dayLost}.");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine($"You made ${dayProfit} today!");
            Console.ReadKey();
        }

    }
    }
}
