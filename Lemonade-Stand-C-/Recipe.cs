using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    public class Recipe
    {
        public int recipeSugar;
        public int recipeLemon;
        public int recipeIce;
        public double lemonadeCost;

        Recipe ()
        {
            recipeSugar = 1;
            recipeLemon = 1;
            recipeIce = 1;

        }


        public double GetLemonadeCost(Store store)
        {
            lemonadeCost = (recipeSugar * store.sugarCost) + (recipeLemon * store.lemonCost) + (recipeIce * store.iceCost) + store.cupCost;
            return lemonadeCost;
        }
        

    }
}
