using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Money : Items
    {
        public Money()
        {
            StartMoney();
        }

        public void StartMoney()
        {
            int startmoney = 10;
            name = "money";

        }
        
    }
}
