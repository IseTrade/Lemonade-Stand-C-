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

        public int PickCup()
        {
            Console.WriteLine("How many cups of lemonade would you like to make");
            recipeCup = int.Parse(Console.ReadLine());
            return recipeCup;
        }

        public double GetLemonadeCost(Store store)
        {
            lemonadeCost = (recipeIce * store.iceCost) + (recipeSugar * store.sugarCost) + (recipeLemon * lemonadeCost) + (recipeCup * store.cupCost);
            return lemonadeCost;
        }

        //Set a price for this secret recipe
        public void SetLemonadePrice()
        {
            Console.WriteLine("Please set the price for a lemonade cup in dollar amount.");
            lemonadePrice = int.Parse(Console.ReadLine());
        }

        public void ShowRecipe(int recipeCup, int recipeIse, int recipeSugar, int recipeLemon)
        {
            Console.WriteLine("Your current recipe for one lemnonade has {0} cup, {1} ice cubes, {2} sugar cubes, and {3} lemons", recipeCup, recipeIse, recipeSugar, recipeLemon);
            Console.WriteLine("Your cost for each lemonaid cup is {0} dollars.", lemonadeCost);
        }
    }
}
