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
        public Wallet wallet;
        public Store()
        {
            lemonCost = 0.15;
            sugarCost = 0.05;
            iceCost = 0.05;
            cupCost = 0.05;
            //Inventory inventory = new Inventory();
            //Store store = new Store();
        }

        public void BuyCup(Inventory inventory, Wallet wallet)
        {
            Console.WriteLine("Please enter the number of cups you want to buy: ");
            int cupBought = int.Parse(Console.ReadLine());
            Console.WriteLine("You bought {0} cups at the cost of {1} dollars.", cupBought, cupBought * cupCost);           
            inventory.cup += cupBought;
            wallet.money -= (cupBought * cupCost);
            Console.WriteLine("You now have {0} cups in your inventory", inventory.cup);
            Console.WriteLine("Your have {0} dollars remaining to spend", wallet.money);
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey();
            //return cupBought;
        }
        public void BuyLemon(Inventory inventory, Wallet wallet)
        {
            Console.WriteLine("Please enter the number of Lemons you want to buy: ");
            int lemonBought = int.Parse(Console.ReadLine());

            Console.WriteLine("You bought {0} lemons at the cost of {1} dollars.", lemonBought, lemonBought * lemonCost);
            inventory.lemon += lemonBought;
            wallet.money -= (lemonBought * lemonCost);
            Console.WriteLine("You now have {0} lemons in your inventory", inventory.lemon);
            Console.WriteLine("Your have {0} dollars remaining to spend", wallet.money);
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey();

            //return lemonBought;
        }

        public void BuyIce(Inventory inventory, Wallet wallet)
        {
            Console.WriteLine("Please enter the number of ice cubes you want to buy: ");
            int iceBought = int.Parse(Console.ReadLine());

            Console.WriteLine("You bought {0} ice cubes at the cost of {1} dollars.", iceBought, iceBought * iceCost);
            inventory.ice += iceBought;
            wallet.money -= (iceBought * iceCost);
            Console.WriteLine("You now have {0} ice cubes in your inventory", inventory.ice);
            Console.WriteLine("Your have {0} dollars remaining to spend", wallet.money);
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey();

            //return iceBought
        }

        public void BuySugar(Inventory inventory, Wallet wallet)
        {
            Console.WriteLine("Please enter the number of Sugar units you want to buy: ");
            int sugarBought = int.Parse(Console.ReadLine());

            Console.WriteLine("You bought {0} sugar units at the cost of {1} dollars.", sugarBought, sugarBought * sugarCost);
            inventory.sugar += sugarBought;
            wallet.money -= (sugarBought * sugarCost);
            Console.WriteLine("You now have {0} cups in your inventory", inventory.sugar);
            Console.WriteLine("Your have {0} dollars remaining to spend", wallet.money);
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey();

            //return sugarBought;
        }

        public void BuySupplies(Inventory inventory, Wallet wallet)
        {
            //Inventory inventory1 = new Inventory();
            //Wallet wallet = new Wallet();
            UI.DisplayStoreMenu();
            Console.WriteLine("Press any key to continue");
            BuyCup(inventory, wallet);
            BuyIce(inventory, wallet);
            BuySugar(inventory, wallet);           
            BuyLemon(inventory,wallet);

        }
    }
}
