using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Wallet
    {
        public double money;
        bool bankrupt;
        double amount;

        public Wallet()
        {
            money = 10;
        }

        public void UpdateFunds(double amount)
        {
            money = money - amount;
        }

        public bool CheckIfBankrupt()
        {
            if (money < amount)
            {
                bankrupt = true;
                Console.WriteLine("You don't have enough money.");
                Console.ReadLine();
            }
            return bankrupt;
        }
    }
}
