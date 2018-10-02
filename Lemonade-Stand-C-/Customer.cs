using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    public class Customer : Common
    {
        //variables
        public double priceDemand;
        public double weatherDemand;
        public double buyChance;
        public Weather weather;
        public List<Customer> customer;

        public Customer()
        {

        }

        //Customer demand depends on overcast condtion, temperature, recipe, price and probabilities
        public double DemandLemonade(Recipe recipe)
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

        //A method which the customer will use to determine if there is a chance of getting lemonade
        public double GetBuyingProbability(Recipe recipe, Weather weather)
        {
            double buyingProbability;
            buyingProbability = GetRandom(50, 90) * priceDemand * weatherDemand;
            return buyingProbability;
        }
    }
}
