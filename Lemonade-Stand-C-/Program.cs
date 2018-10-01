using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    /// <summary>
    /// A Lemonade Stand game
    /// </summary>
    class Program
    {
        //The application runs
        public static void Main(string[] args)
        {
            //Application creates a game object
            Game lemonadeStand = new Game();

            //Application enters the game via the RunGame method
            lemonadeStand.RunGame();
        }
    }
}