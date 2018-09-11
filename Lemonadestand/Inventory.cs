using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    class Inventory
    {
        // Member Variables
        public int lemon;
        public int ice;
        public int suger;
        public int cup;
        public bool enoughInventory;
        Wallet money;



        //Constructor
        public Inventory()
        {
            money = new Wallet();
        }


        //Member Methods

        public void SubtractInventory()
        {
            lemon = lemon - 1;
            ice = ice - 1;
            suger = suger - 1;
            cup = cup - 1;
        }

        public bool CheckInventory()
        {
            if (lemon >= 1 && ice >= 1 && suger >= 1 && cup >= 1)
                enoughInventory = true;
            else
            {
                enoughInventory = false;

                UserInterface.DisplayMessage("You are out of Lemonade! You will need to buy more for tomorrow!!");
            }

            return enoughInventory;
        }

        public void DisplayInventory()
        {
            UserInterface.DisplayMessage("Inventory: " + lemon + " Lemons, " + ice + " Ice, " + suger + " Suger, " + cup + " Cups, ");

        }


        public void DisplayWalletandInventory()
        {
            UserInterface.DisplayMessage("Inventory: " + lemon + " Lemons, " + ice + " Ice, " + suger + " Suger, " + cup + " Cups, ");
            UserInterface.DisplayMessage("Money: " + money);
        }
    }
}
