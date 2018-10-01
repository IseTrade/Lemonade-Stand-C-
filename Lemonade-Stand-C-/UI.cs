using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    /// <summary>
    /// A UI class which presents visible elements of the game
    /// </summary>
    public class UI
    {
        public static void ShowRules()
        {
            Console.WriteLine("Welcome to Jeff's Lemonade Stand Game\n\n");
            Console.WriteLine("In this game, you are the proprietor of a lemonade stand. Your object, just like in any other businesses");
            Console.WriteLine("is to make money. You'll start out with 30 dollars and you can use that money to buy supplies");
            Console.WriteLine("such as cups, lemons, ice cubes, and sugar. You have to consider factors such as weather condition,");
            Console.WriteLine("temperature, price per lemonaid cup, and the fickeness of customers. You are alllowed to buy only");
            Console.WriteLine("once/day from the store. So buy enough for the day. Once you've run out of supplies, the game ends.");
            Console.WriteLine("You can adjust the recipe of your lemonade to attract more customers. You hav 7 days to see how much profit you");
            Console.WriteLine("can make. GOOD LUCK.");
            Console.ReadKey();
        }

        public static void ShowStoreMenu()
        {
            Console.WriteLine("WELCOME TO THE STORE\n\n");
            Console.WriteLine("As long as you have enough money you can buy items such as cups, lemons, ice and sugar from us.");
            Console.WriteLine("Please keep in mind that you're only able to purchase from us once/day.");
            Console.WriteLine("So, what would you like to buy today?\n");
            Console.ReadKey();
        }

        public static void ShowRecipeMenu()
        {
            Console.WriteLine("Welcome to the recipe menu. Here you can hone your skills to make the perfect lemonade for");
            Console.WriteLine("your customers. You can adjust the amount of sugar, lemon and ice that goes into each cup.");
            Console.WriteLine("Please press any key to continue.");
            Console.ReadKey();
        }
        public static void PressKey()    // This adds a pause to screen display
        {
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey();
        }
        public static void ShowInventory(Inventory playerInventory, Wallet playerWallet)
        {
            Console.WriteLine("Current you have {0} cups, {1} lemons, {2} ice cubes, {3} units of sugar, and {4} dollars to spend...", playerInventory.cup, playerInventory.lemon, playerInventory.ice, playerInventory.sugar, playerWallet.money);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
