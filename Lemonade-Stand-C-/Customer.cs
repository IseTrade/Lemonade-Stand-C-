using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    public class Customer
    {
        //variables
        public double priceDemand;
        public double weatherDemand;
        public double buyChance;
        public Weather weather;
        //static Random rand = new Random();
        public int customerBase = 30; // pool of potential customers for the lemonade stand
        public List<Customer> customer;

        public Customer()
        {
        
        }

    // Customer demand depends on overcast condtion, temperature, recipe, price of lemonade, and each individual's chance
    // of buying
    public double DemandLemonade(Recipe recipe)  // depends on lemonade recipe --cheapest a cost is 0.30
        {
            if (recipe.lemonadePrice <= .50)
            {
                priceDemand = 0.80;
            }
            else if (recipe.lemonadePrice >= .51 && recipe.lemonadePrice <= .75)
            {
                priceDemand = 0.60;
            }
            else if (recipe.lemonadePrice >= .76 && recipe.lemonadePrice <= 1.00)
            {
                priceDemand = 0.40;
            }
            else if (recipe.lemonadePrice >= 1.01)
            {
                priceDemand = 0.20;
            }
            return priceDemand;
        }
    public double GetWeatherDemand(Weather weather)
        {
            if (weather.weatherIndex == 4)
            {
                weatherDemand = 0.90;
            }
            else if (weather.weatherIndex == 3)
            {
                weatherDemand = 0.70;
            }
            else if (weather.weatherIndex == 2)
            {
                weatherDemand = 0.50;
            }
            else if (weather.weatherIndex == 1)
            {
                weatherDemand = 0.30;
            }
            else if (weather.weatherIndex == 0)
            {
                weatherDemand = 0.10;
            }
            return weatherDemand;
        }
        public double BuyOrNot(Recipe recipe, Weather weather) 
            // varies from customer to customer. This is the final % factoring weather, temp, demand, lemonade price.
        {
            Random rnd = new Random();
            buyChance = rnd.Next(50, 90) * priceDemand * weatherDemand;
            return buyChance;
        }

   

    }
}
