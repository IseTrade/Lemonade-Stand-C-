using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    public class Wallet
    {
        public double money = 30.00;
        public double profit = 0;
        public double dailyLoss = 0;   //unsold lemonoid + unused ice cubes
        public double dailyProfit = 0;  //total cups sold - dailyLoss
        public double totalGameProfit = 0;
        public double totalGameLoss = 0;

    }
}
