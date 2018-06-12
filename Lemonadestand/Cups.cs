using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Cups : Items
    {
        public double priceToSell;
        public Cups()
        {
            price = .10;
            name = "cups";
            priceToSell = 0;
        }
    }
}
