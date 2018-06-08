using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Player
    {
        public Money money;

        public Player()
        {
            money = new Money();
        }

        public void ChoosePitchersAndCups()
        {
            ChoosePitchers();
            ChooseCups();

            Console.ReadLine();
        }
        // choose how many pitchers
        public void ChoosePitchers()
        {

            Console.WriteLine(money.Money);
            Console.WriteLine("\nPlease choose how many pitchers you want. 1 pitcher = $2");

        
            
        }

        // choose how many cups
        public void ChooseCups()
        {
            Console.WriteLine("Choose how many cups you want to sell");
        }
    }
}
