using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Player
    {
        public string choice;

        public Player()
        {

        }

        // choose how many pitchers
        public void ChoosePitchers()
        {
            Console.WriteLine("Choose how many pitchers you want to make.");
            choice = Console.ReadLine();
        }

        // choose how many cups
        public void ChooseCups()
        {
            Console.WriteLine("Choose how many cups you want to sell");
            choice = Console.ReadLine();
        }
    }
}
