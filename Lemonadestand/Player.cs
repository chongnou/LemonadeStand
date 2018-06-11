﻿using System;
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

        public void ChoosePitchers()
        {
            string userInput;
            
            Console.WriteLine("\nPlease choose how many pitchers you want. 1 pitcher = $2");
            Console.WriteLine("Remember to buy cups also!");
            userInput = Console.ReadLine();


            if (userInput == "1")
            {
                Console.WriteLine("Cost = $2");
                wallet.money -= 2;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
            else if (userInput == "2")
            {
                Console.WriteLine("Cost = $4");
                wallet.money -= 4;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
            else if (userInput == "3")
            {
                Console.WriteLine("Cost = $6");
                wallet.money -= 6;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
            else if (userInput == "4")
            {
                Console.WriteLine("Cost = $8");
                wallet.money -= 8;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
            else if (userInput == "5")
            {
                Console.WriteLine("Cost = $10");
                wallet.money -= 10;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
            else if (userInput == "6")
            {
                Console.WriteLine("Cost = $12");
                wallet.money -= 12;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
            else if (userInput == "7")
            {
                Console.WriteLine("Cost = $14");
                wallet.money -= 14;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
            else if (userInput == "8")
            {
                Console.WriteLine("Cost = $16");
                wallet.money -= 16;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);
            }
            else if (userInput == "9")
            {
                Console.WriteLine("Cost = $18");
                wallet.money -= 18;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
            else if (userInput == "10")
            {
                Console.WriteLine("Cost = $20");
                wallet.money -= 20;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
            else
            {
                Console.WriteLine("Invalid Input, try again.");
            }
        }

        // choose how many cups
        public void ChooseCups()
        {
            Console.WriteLine("\nChoose how many cups you want to sell. 1 cup = 10¢");

            string userInput;
            
            userInput = Console.ReadLine();


            if (userInput == "1")
            {
                Console.WriteLine("Cost = 10¢");
                wallet.money -= .10;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
            else if (userInput == "2")
            {
                Console.WriteLine("Cost = 20¢");
                wallet.money -= .20;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
            else if (userInput == "3")
            {
                Console.WriteLine("Cost = 30¢");
                wallet.money -= .30;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
            else if (userInput == "4")
            {
                Console.WriteLine("Cost = 40¢");
                wallet.money -= .40;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
            else if (userInput == "5")
            {
                Console.WriteLine("Cost = 50¢");
                wallet.money -= .50;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
            else if (userInput == "6")
            {
                Console.WriteLine("Cost = 60¢");
                wallet.money -= .60;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
            else if (userInput == "7")
            {
                Console.WriteLine("Cost = 70¢");
                wallet.money -= .70;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
            else if (userInput == "8")
            {
                Console.WriteLine("Cost = 80¢");
                wallet.money -= .80;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);
            }
            else if (userInput == "9")
            {
                Console.WriteLine("Cost = 90¢");
                wallet.money -= .90;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
            else if (userInput == "10")
            {
                Console.WriteLine("Cost = $1");
                wallet.money -= 1;
                wallet.CheckIfBankrupt();
                Console.WriteLine("Money left: " + wallet.money);

            }
        }
    }
}