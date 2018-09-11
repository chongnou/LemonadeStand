using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    class Store
    {
        // Member Variables
        public double chargePrice;
        public int restockChoice;
        Inventory inventory;
        Inventory lemon;
        Inventory ice;
        Inventory suger;
        Inventory cup;
        Wallet money;
        Wallet wallet;

        //Constructor
        public Store()
        {

            inventory = new Inventory();
            lemon = new Inventory();
            ice = new Inventory();
            suger = new Inventory();
            cup = new Inventory();
            money = new Wallet();
            wallet = new Wallet();
        }


        //Member Methods
        public double InputPrice()
        {
            UserInterface.DisplayMessage("How much would you like to charge for a cup of lemonade? example");
            UserInterface.DisplayMessage("example 50 cents would be .50, 1 dollor would be 1.00");
            chargePrice = double.Parse(UserInterface.GetUserInput());
            if (chargePrice <= 0.009)
            {
                UserInterface.DisplayMessage("Please Try Again");
                InputPrice();
            }
            else if (chargePrice >= 3.00)
            {
                UserInterface.DisplayMessage("Your price is a little high, and so are you!!!");
                UserInterface.DisplayMessage("Please Try Again");
                InputPrice();
            }

            UserInterface.DisplayMessage("Todays price per cup is " + chargePrice);
            return chargePrice;
        }


        public double BuyLemon()
        {
            UserInterface.DisplayMessage("Your currantly have: " + inventory.lemon + " Lemons ");
            UserInterface.DisplayMessage("Lemons cost $0.50 each. How many Lemons would you like to buy? ");
            restockChoice = int.Parse(UserInterface.GetUserInput());

            if (wallet.money - (restockChoice * .50) < 0)
            {
                UserInterface.DisplayMessage("Sorry you do not have enought money. Plese try again.");
                BuyLemon();
            }
            else
            {

                inventory.lemon = inventory.lemon + restockChoice;
                wallet.money = wallet.money - (restockChoice * .50);
                UserInterface.DisplayMessage("You restocked with Lemons");
                UserInterface.DisplayMessage("You have " + inventory.lemon + " Lemons");
                UserInterface.DisplayMessage("You have $" + wallet.money + " left in you wallet.");
                return inventory.lemon;
            }

            return wallet.money;

        }


        public double BuyIce()
        {
            UserInterface.DisplayMessage("Your currantly have: " + inventory.ice + " servings of Ice");
            UserInterface.DisplayMessage("Ice cost $0.25 per serving. How many servings would you like to buy? ");
            restockChoice = int.Parse(UserInterface.GetUserInput());

            if (wallet.money - (restockChoice * .25) < 0)
            {
                UserInterface.DisplayMessage("Sorry you do not have enought money. Plese try again.");
                BuyIce();
            }
            else
            {

                inventory.ice = inventory.ice + restockChoice;
                wallet.money = wallet.money - (restockChoice * .25);
                UserInterface.DisplayMessage("You restocked with Ice");
                UserInterface.DisplayMessage("You have " + inventory.ice + " servings of Ice.");
                UserInterface.DisplayMessage("You have $" + wallet.money + " left in you wallet.");
                return inventory.ice;
            }

            return wallet.money;

        }


        public double BuySuger()
        {
            UserInterface.DisplayMessage("Your currantly have: " + inventory.suger + " Servings of Suger");
            UserInterface.DisplayMessage("Ice cost $0.10 per serving. How many servings would you like to buy? ");
            restockChoice = int.Parse(UserInterface.GetUserInput());

            if (wallet.money - (restockChoice * .10) < 0)
            {
                UserInterface.DisplayMessage("Sorry you do not have enought money. Plese try again.");
                BuySuger();
            }
            else
            {

                inventory.suger = inventory.suger + restockChoice;
                wallet.money = wallet.money - (restockChoice * .10);
                UserInterface.DisplayMessage("You restocked with Suger");
                UserInterface.DisplayMessage("You have " + inventory.suger + " servings of Suger");
                UserInterface.DisplayMessage("You have $" + wallet.money + " left in you wallet.");
                return inventory.suger;
            }

            return wallet.money;

        }


        public double BuyCup()
        {
            UserInterface.DisplayMessage("Your currantly have: " + inventory.cup + " Cups");
            UserInterface.DisplayMessage("Ice cost $.50 per cup. How many cups would you like to buy? ");
            restockChoice = int.Parse(UserInterface.GetUserInput());

            if (wallet.money - (restockChoice * .50) < 0)
            {
                UserInterface.DisplayMessage("Sorry you do not have enought money. Plese try again.");
                BuyCup();
            }
            else
            {

                inventory.cup = inventory.cup + restockChoice;
                wallet.money = wallet.money - (restockChoice * .50);
                UserInterface.DisplayMessage("You restocked with Cups");
                UserInterface.DisplayMessage("You have " + inventory.cup + " Cups");
                UserInterface.DisplayMessage("You have $" + wallet.money + " left in you wallet.");
                return inventory.cup;
            }

            return wallet.money;

        }
    }
}
