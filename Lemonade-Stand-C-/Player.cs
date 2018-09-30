using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_C_
{
    public class Player
    {
        public Player player;
        public Wallet wallet;
        public Inventory inventory;
        public Recipe recipe;
        public int soldLemonade;
        public Player()
        {
            soldLemonade = 0;
        }

        public void HasInventory()
        {

        }
        public void HasCup()
        {

        }
        public void HasSugar()
        {

        }
        public void HasIce()
        {

        }
        public void HasLemon()
        {

        }

        public void HasLemonade()
        {

        }
        public int SellLemonade(List<Customer> customer)
        { 
            //public int soldLemonade = 0;
            for (int i = 0; i < customer.Count; i++)
            {
                if (lemonade == 0)
                {
                    Console.WriteLine("You sold out and have no more cups of lemonade!");
                    Console.ReadKey();
                    Console.Clear();
                    
                }
                else
                {
                    if (customer[i].buyProbability >= 40)
                    {
                        soldLemonade++;
                        lemonade--;
                        break;
                    } 
                    else 
                    {
                           //no sale
                    }

                }
            }
            return soldLemonade;
        }
        public void RemoveExpiredInventory()
        {
            Lemonade = 0; //Throwing old unsold Lemonade at end of day
            ice = 0; //set ice cube count to 0 at end of day
        }
    }
}
