using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    /// <summary>
    /// The Lemonade Stand Game
    /// </summary>
    public class Game
    {
        //Create the game objects
        public Player player;
        public Customer customer;
        public Inventory inventory;
        public Day day;
        public Store store;
        public Recipe recipe;
        public Weather weather;
        public static Random rnd;
        public Wallet wallet;
        public static Random rand = new Random();//A fixed random seed to avoid the same random value with new Random()

        //Initialize the class variables
        public Game()
        {
            player = new Player();
            store = new Store();
            day = new Day();
            weather = new Weather();
            recipe = new Recipe();
        }

        //Start the game
        public void RunGame()
        {
            //Show the initital game menu
            UI.ShowRules();

            //0. Check the weather forecast
            day.GetWeather();
            day.GetForecast();

            weather.ShowWeekForecast();
            weather.ShowCurrentWeather();
            Console.ReadKey();
            UI.ShowStoreMenu();
            Console.ReadKey();
            player.BuySupplies(Store store, Inventory inventory, Wallet wallet);



            //1. Purchase items from the store
            //TODO

            //2. Make lemonade with the purchased items
            //TODO

            //3. Get the weather forecast
            //TODO

            //4. Sell lemonade to customer
            //TODO

            //5. Calculate profits
            //TODO

            //6. Restock items from the store
            //TODO
        }
    }
}
