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
        

        public Store()
        {
            lemonCost = 0.15;
            sugarCost = 0.05;
            iceCost = 0.05;
            cupCost = 0.05;
        }      
    }
}