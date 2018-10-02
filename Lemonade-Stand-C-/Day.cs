using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    /// <summary>
    /// A class which describes daily lemonade stand operations
    /// </summary>
    public class Day:Common
    {
        public Weather weather;
        public Player player;

        public int day;

        public List<Customer> customer;

        public double daySupplyCost;
        public double dayRevenue;
        public double dayProfit;
        public double dayLoss;

        //public static Random rand = new Random();

        public Day()
        {
            day = 1;
            weather = new Weather();
            customer = new List<Customer>();
        }

        public Weather GetWeather()
        {
            return this.weather;
        }

        public void GetForecast()
        {
            //TODO
        }

        public void DisplayDay()
        {
            Console.WriteLine($"Today is Day {day}\n\n");

        }
        public void GetDayCustomers(Weather weather)
        {
            if (weather.weatherIndex == 4)
            {
                int numberCustomer = GetRandom(25, 30);
                for (int i = 0; i < numberCustomer; i++)
                {
                    customer.Add(new Customer());
                }
            }
            else if (weather.weatherIndex == 3)
            {
                int numberCustomer = GetRandom(15, 25);
                for (int i = 0; i < numberCustomer; i++)
                {
                    customer.Add(new Customer());
                }
            }
            else if (weather.weatherIndex == 2)
            {
                int numberCustomer = GetRandom(5, 15);
                for (int i = 0; i < numberCustomer; i++)
                {
                    customer.Add(new Customer());
                }
            }
            else if (weather.weatherIndex == 1)
            {
                int numberCustomer = GetRandom(0, 10);
                for (int i = 0; i < numberCustomer; i++)
                {
                    customer.Add(new Customer());
                }
            }
            else if (weather.weatherIndex == 0)
            {
                int numberCustomer = GetRandom(0, 5);
                for (int i = 0; i < numberCustomer; i++)
                {
                    customer.Add(new Customer());
                }
            }
        }

        public void DayCost() //cost of all coffee made + unsold ice
        {
            //TODO
        }

        public double GetDayRevenue(Player player, Recipe recipe)
        {
            return player.lemonadeSold * recipe.lemonadePrice;
        }

        public double GetDayProfit()
        {
            return dayRevenue - daySupplyCost;
        }

        public double GetDayLoss()
        {
            return daySupplyCost - dayProfit;
        }

        public void DisplayDayProfit()
        {
            if (dayProfit <= 0)
            {
                Console.WriteLine($"You lost money today! You lost {dayLoss}.");
            }
            else
            {
                Console.WriteLine($"You made {dayProfit} today!");
            }

        }
    }
}
