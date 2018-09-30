using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    public class Game
    {
        public Player player;
        public Customer customer;
        public Day day;
        public Store store;
        public Recipe recipe;
        public Weather weather;
        public Random rnd;
        public UI ui;
        public Wallet wallet;
        public Game()
        {
            player = new Player();
            store = new Store();
            ui = new UI();
            day = new Day();
            rnd = new Random();
            weather = new Weather();
            recipe = new Recipe();
        }

        //public void Test()
        //{
        public void RunGame()
        {
            UI.ShowRules();
            Console.Clear();
            day.GetWeather();
            day.GetForecast();

            weather.WeekForecast();
            weather.DayForecast();
            Console.Clear();
            weather.TodayWeather();


            store.BuyLemon(player.inventory, player.wallet);
        }


        //    Console.WriteLine(player.wallet.money);
        //    Console.ReadKey();
        //}
    }
}
