using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    /// <summary>
    /// A common set of functions to use between classes using inheritance
    /// </summary>
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