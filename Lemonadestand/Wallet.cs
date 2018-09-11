using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    class Wallet
    {
        // Member Variables
        public double money;
        
        //Constructor
        public Wallet()
        {
            money = 20.00;
        }
        
        // Methods
        public double DisplayMoneyInWallet()
        {
            UserInterface.DisplayMessage("You have $" + money + " Left in your Wallet");
            return money;
        }
    }
}
