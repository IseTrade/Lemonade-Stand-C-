using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{

    // A common set of functions to use between classes using inheritance
    // Randomizer is used quite a bit in this game, so putting it in its own class and method can be useful for other classes that need this feature.
    public class Common
    {
        //A common public random generator function
        public int GetRandom(int a, int b)
        {
            int randomNumber = Game.rand.Next(a, b);
            return randomNumber;
        }
    }
}