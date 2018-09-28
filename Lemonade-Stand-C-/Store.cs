using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    public class Store
    {
        public double lemonCost;
        public double sugarCost;
        public double iceCost;
        public double cupCost;
        public Inventory inventory;

        public Store()
        {
            lemonCost = 0.15;
            sugarCost = 0.05;
            iceCost = 0.05;
            cupCost = 0.10;
            Inventory inventory = new Inventory();
            Store store = new Store();
        }

        public int BuyCup(Inventory inventory)
        {
            Console.WriteLine("Please enter the number of cups you want to buy: ");
            int cupBought = int.Parse(Console.ReadLine());
            Console.WriteLine("You bought {0} cups at the cost of {1} dollars.", cupBought, cupBought * cupCost);
            Console.ReadKey();
            //int cup += cupsBought;
            return cupBought;
        }
        public int BuyLemon(Inventory inventory)
        {
            Console.WriteLine("Please enter the number of Lemons you want to buy: ");
            int lemonsBought = int.Parse(Console.ReadLine());
            return lemonsBought;
        }

        public int BuyIce(Inventory inventory)
        {
            Console.WriteLine("Please enter the number of ice cubes you want to buy: ");
            int iceBought = int.Parse(Console.ReadLine());
            return iceBought;
        }

        public int BuySugar(Inventory inventory)
        {
            Console.WriteLine("Please enter the number of Sugar units you want to buy: ");
            int sugarBought = int.Parse(Console.ReadLine());
            return sugarBought;
        }

        public void BuySupplies()
        {
            BuyIce(inventory);
            BuySugar(inventory);
            BuyCup(inventory);
            BuyLemon(inventory);

        }
    }
}
