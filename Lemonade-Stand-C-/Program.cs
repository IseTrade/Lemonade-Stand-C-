using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    class Program
    {
        //variables
        //Inventory inventory;
        //Wallet wallet;
        

        static void Main(string[] args)
        {
            //Game rungame = new Game();
            //rungame.RunGame();


            Weather weather = new Weather();
            Store store = new Store();
            Wallet wallet = new Wallet();
            Inventory inventory = new Inventory();

            //weather.DayForecast(); //tested ok for generating random daily weather. Need more work on this!!!
            //Console.ReadLine();

            //Console.WriteLine(weather.GetRandomCondition());
            //Console.ReadKey();
            //store.BuyCup(inventory, wallet);

            ////store.BuyCup(inventory, wallet);
            ////store.BuyLemon(inventory, wallet);

            //store.BuySupplies(inventory, wallet);
            //UI.DisplayInventory(inventory, wallet);




        }
        
    }
}
