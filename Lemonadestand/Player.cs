using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Player
    {
        public Wallet wallet;

        public Player()
        {
            wallet = new Wallet();
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
            string userInput;
            
            Console.WriteLine("\nPlease choose how many pitchers you want. 1 pitcher = $2");
            userInput = Console.ReadLine();


            if (userInput == "1")
            {
                Console.WriteLine("Cost = $2");

            }
            else if (userInput == "2")
            {
                Console.WriteLine("Cost = $4");
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Cost = $6");
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Cost = $8");
            }
            else if (userInput == "5")
            {
                Console.WriteLine("Cost = $10");
            }
            else if (userInput == "6")
            {
                Console.WriteLine("Cost = $12");
            }
            else if (userInput == "7")
            {
                Console.WriteLine("Cost = $14");
            }
            else if (userInput == "8")
            {
                Console.WriteLine("Cost = $16");
            }
            else if (userInput == "9")
            {
                Console.WriteLine("Cost = $18");
            }
            else if (userInput == "10")
            {
                Console.WriteLine("Cost = $20");
            }
            else
            {
                Console.WriteLine("Invalid Input, try again.");
            }
        }

        // choose how many cups
        public void ChooseCups()
        {
            Console.WriteLine("Choose how many cups you want to sell");
        }
    }
}
