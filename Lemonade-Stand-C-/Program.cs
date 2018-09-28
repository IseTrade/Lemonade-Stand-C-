using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Weather weather = new Weather();
            //Store store = new Store();
            //Inventory inventory = new Inventory();

            //weather.DayForecast(); //tested ok for generating random daily weather. Need more work on this!!!
            //Console.ReadLine();

            Console.WriteLine(weather.DayScore());
            Console.ReadKey();
            //store.BuyCup(inventory);



        }
        
    }
}
