using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    /// <summary>
    /// A class which describes a store for the required items needed to be purchased
    /// </summary>
    public class Store
    {
        public double lemonCost;
        public double sugarCost;
        public double iceCost;
        public double cupCost;
        Player player;
        //UI ui;

        public Store()
        {
            lemonCost = 0.15;
            sugarCost = 0.05;
            iceCost = 0.05;
            cupCost = 0.05;
        }

        //abilities of the store keeper

        //assume store keeper has unlimited stock and we don't need to keep track of his inventories

        //public int SellLemon(Inventory playerInventory, Wallet playerWallet)
        //{
        //    Console.WriteLine("How many lemons would you like buy?");
        //    int lemonsBought = int.Parse(Console.ReadLine());
        //    playerWallet.money -= lemonsBought * lemonCost; //decreases money by amount spent on lemons
        //    playerInventory.lemon += lemonsBought; // added to stock lemon inventory
        //    Console.ReadKey();
        //    return playerInventory.lemon;  //return value to current number of lemons in stock     
        //}

        //public int SellSugar(Inventory playerInventory, Wallet playerWallet)
        //{
        //  Console.WriteLine("How many sugar cubes would you like to buy?");
        //    int sugarBought = int.Parse(Console.ReadLine());
        //    playerWallet.money -= sugarBought * sugarCost; 
        //    playerInventory.lemon += sugarBought; 
        //    Console.ReadKey();
        //    return playerInventory.sugar;
        //}

        //public int SellIce(Inventory playerInventory, Wallet playerWallet)
        //{
        //    Console.WriteLine("How many ice cubes would you like to buy?");
        //    int iceBought = int.Parse(Console.ReadLine());
        //    playerWallet.money -= iceBought * iceCost;
        //    playerInventory.ice += iceBought;
        //    Console.ReadKey();
        //    return playerInventory.ice;
        //}

        //public int SellCup(Inventory playerInventory, Wallet playerWallet)
        //{
        //    Console.WriteLine("How many cups would you like to buy?");
        //    int cupBought = int.Parse(Console.ReadLine());
        //    playerWallet.money -= cupBought * cupCost;
        //    playerInventory.cup += cupBought;
        //    Console.ReadKey();
        //    return playerInventory.cup;
        //}

        //public void Sell(Inventory inventory, double itemCost)
        //{


        }

        //The store keeper checks his stock
        public void CheckStock(Inventory playerInventory)
        {
            //TODO
            //Print the items left in the store
        }
    }
}