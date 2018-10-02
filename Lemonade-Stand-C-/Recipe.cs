using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    /// <summary>
    /// A class which describes how to make our special lemonade
    /// </summary>
    public class Recipe
    {
        public int recipeSugar;
        public int recipeLemon;
        public int recipeIce;
        public int recipeCup;
        //Inventory playerInventory;
        //Wallet playerWallet;
        public double lemonadeCost;
        public double lemonadePrice;

        //Our secret recipe involves 1 of each item
        //We must have at least 1 item in stock to make lemonade
        public Recipe()
        {
            recipeSugar = 1;
            recipeLemon = 1;
            recipeIce = 1;
            recipeCup = 1;
        }

        public void AskNewRecipe()
        {
            Console.WriteLine("Do you want to make a new recipe?");

        }

        // **** The methods below such as PickLemon, PickSugar, PickIce, and PickRecipe follow SOLID's Single Responsibility principle, that each method does
        // **** one thing and one thing well.
        public int PickLemon()
        {
            Console.WriteLine("How many lemons would you like to put in your each cup?");
            recipeLemon = int.Parse(Console.ReadLine());
            return recipeLemon;
        }

        public int PickSugar()
        {
            Console.WriteLine("How many sugar cubes would you like to put in your each cup?");
            recipeSugar = int.Parse(Console.ReadLine());
            return recipeSugar;
        }

        public int PickIce()
        {
            Console.WriteLine("How many ice cubes would you like to put in your each cup?");
            recipeIce = int.Parse(Console.ReadLine());
            return recipeIce;
        }
        public void PickRecipe(Recipe recipe)
        {
            PickLemon();
            PickSugar();
            PickIce();
        }
        public int MakeLemonade(Inventory playerInventory)
        {
            Console.WriteLine("How many cups of lemonade would you like to make");
            playerInventory.lemonade = int.Parse(Console.ReadLine());
            playerInventory.ice -= playerInventory.lemonade * recipeIce;
            playerInventory.sugar -= playerInventory.lemonade * recipeSugar;
            playerInventory.cup -= playerInventory.lemonade * recipeCup;
            playerInventory.lemon -= playerInventory.lemonade * recipeLemon;
            return playerInventory.lemonade;
        }

        public double GetLemonadeCost(Store store)
        {
            lemonadeCost = (recipeIce * store.iceCost) + (recipeSugar * store.sugarCost) + (recipeLemon * store.lemonCost) + (1 * store.cupCost);
            return lemonadeCost;
        }

        //Set a price for this secret recipe
        public void SetLemonadePrice()
        {
            Console.WriteLine("Please set the price for a lemonade cup in dollar amount.");
            lemonadePrice = double.Parse(Console.ReadLine());
            UI.PressKey();  //This gives a quick way to prompt "press any key to continue".
        }

        public void ShowRecipe(int recipeIce, int recipeSugar, int recipeLemon)
        {
            Console.WriteLine("Your current recipe for one lemnonade has 1 cup, {0} ice cubes, {1} sugar cubes, and {2} lemons",recipeIce, recipeSugar, recipeLemon);
            Console.WriteLine("Your cost for each lemonaid cup is {0} dollars.", lemonadeCost);
            UI.PressKey();
        }
    }
}
