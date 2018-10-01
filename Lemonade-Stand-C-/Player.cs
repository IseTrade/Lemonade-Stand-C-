using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    public class Player
    {
        public int lemonadeSold;
        public int dayRevenue;

        //Initalize the lemonade stand operator stock and wallet
        public Player()
        {
            Inventory playerInventory = new Inventory();
            Wallet playerWallet = new Wallet();

            //Donated funds
            playerWallet.money = 30.00;
            lemonadeSold = 0;
        }

        //Abilities the Lemonade Stand operator will have
        //Purchase items from a store, store it in stock, charge wallet

        public void BuyCup(Store store, Inventory playerInventory, Wallet playerWallet)
        {
            Console.WriteLine("Please enter the number of cups you want to buy:");
            int cupBought = int.Parse(Console.ReadLine());
            Console.WriteLine("You bought {0} cups at the cost of {1} dollars.", cupBought, cupBought * store.cupCost);
            playerInventory.cup += cupBought;
            playerWallet.money -= (cupBought * store.cupCost);
            Console.WriteLine("You now have {0} cups in your inventory", playerInventory.cup);
            Console.WriteLine("Your have {0} dollars remaining to spend", playerWallet.money);
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey();
        }

        public void BuyLemon(Store store, Inventory playerInventory, Wallet playerWallet)
        {
            Console.WriteLine("Please enter the number of Lemons you want to buy: ");
            int lemonBought = int.Parse(Console.ReadLine());

            Console.WriteLine("You bought {0} lemons at the cost of {1} dollars.", lemonBought, lemonBought * store.lemonCost);
            playerInventory.lemon += lemonBought;
            playerWallet.money -= (lemonBought * store.lemonCost);
            Console.WriteLine("You now have {0} lemons in your inventory", playerInventory.lemon);
            Console.WriteLine("Your have {0} dollars remaining to spend", playerWallet.money);
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey();
        }

        public void BuyIce(Store store, Inventory playerInventory, Wallet playerWallet)
        {
            Console.WriteLine("Please enter the number of ice cubes you want to buy: ");
            int iceBought = int.Parse(Console.ReadLine());

            Console.WriteLine("You bought {0} ice cubes at the cost of {1} dollars.", iceBought, iceBought * store.iceCost);
            playerInventory.ice += iceBought;
            playerWallet.money -= (iceBought * store.iceCost);
            Console.WriteLine("You now have {0} ice cubes in your inventory", playerInventory.ice);
            Console.WriteLine("Your have {0} dollars remaining to spend", playerWallet.money);
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey();
        }

        public void BuySugar(Store store, Inventory playerInventory, Wallet playerWallet)
        {
            Console.WriteLine("Please enter the number of Sugar units you want to buy: ");
            int sugarBought = int.Parse(Console.ReadLine());

            Console.WriteLine("You bought {0} sugar units at the cost of {1} dollars.", sugarBought, sugarBought * store.sugarCost);
            playerInventory.sugar += sugarBought;
            playerWallet.money -= (sugarBought * store.sugarCost);
            Console.WriteLine("You now have {0} cups in your inventory", playerInventory.sugar);
            Console.WriteLine("Your have {0} dollars remaining to spend", playerWallet.money);
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey();
        }

        public void BuySupplies(Store store, Inventory playerInventory, Wallet playerWallet)
        {
            UI.ShowStoreMenu();
            Console.WriteLine("Press any key to continue");

            //Purchase items from the store, save it to stock, bill wallet
            BuyCup(store, playerInventory, playerWallet);
            BuyIce(store, playerInventory, playerWallet);
            BuySugar(store, playerInventory, playerWallet);
            BuyLemon(store, playerInventory, playerWallet);
        }

        //Check if there is stock to make lemonade each time we need to
        public Boolean HasStock(Inventory inventory)
        {
            //Check all the required items using the helper methods
            if (HasCup(inventory) && HasSugar(inventory) && HasIce(inventory) && HasLemon(inventory))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper methods to check our stock and return true/false if we have a minimum of 1 item to meet our recipe
        public Boolean HasCup(Inventory inventory)
        {
            if (inventory.cup >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean HasSugar(Inventory inventory)
        {
            if (inventory.sugar >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean HasIce(Inventory inventory)
        {
            if (inventory.ice >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean HasLemon(Inventory inventory)
        {
            if (inventory.lemon >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean HasLemonade(Inventory inventory)
        {
            if (inventory.lemonade >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Make lemonade to sell
        public void MakeLemonade(Inventory inventory, Recipe recipe)
        {
            Console.WriteLine("I am making lemonade!");
            inventory.lemon--;
            inventory.ice--;
            //cups is not used during this process but 1 lemonade jug
            inventory.lemonade += 1;
        }

        //Sell lemonade given all these paramaters to consider
        public int SellLemonade(Recipe recipe, Weather weather, List<Customer> customer, Player player, Inventory inventory)
        {
            //public int soldLemonade = 0;
            for (int i = 0; i < customer.Count; i++)
            {
                if (inventory.lemonade == 0)
                {
                    Console.WriteLine("You sold out and have no more cups of lemonade!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    if (customer[i].GetBuyingProbability(recipe, weather) >= 40)
                    {
                        player.lemonadeSold++;
                        inventory.lemonade--; //sell the entire jug of lemonade? sell 4 cups per 1 jug?
                        break;
                    }
                    //No profit
                }
            }
            return lemonadeSold;
        }

        //Remoe expired items from our stock
        public void RemoveExpiredItems(Inventory inventory)
        {
            inventory.lemonade = 0; //Set lemonade count to 0 because it's spoiled. FDA warns of bad lemonade.
            inventory.ice = 0; //Set ice cube count to 0 because it melted and can't be reused
        }
    }
}
