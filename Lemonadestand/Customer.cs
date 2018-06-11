using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Customer
    {
        // Random customers depending on weather
        //  More customers on sunny days
        // Less customers on cloudy days
        // Couple customers for raining days



        public Customer()
        {

        }

        public void ChanceToBuyTemperature(Weather weather)
        {

            if (weather.temperature == "90°")
            {
                // people buy more
            }
            else if (weather.temperature == "70°")
            {
                // people buy less
            }
            else if (weather.temperature == "50°")
            {
                // 1 - 3 customers
            }
        }

        public void ChanceToBuyCondition(Weather weather)
        {
            Random rnd = new Random();

            if (weather.condition == "Sunny")
            {
                // people buy more
            }
            else if (weather.condition == "Cloudy")
            {
                // people buy less
            }
            else if (weather.condition == "Raining")
            {
                // 1 - 3 customers
            }
        }

        public void CustomerChanceOfBuying()
        {

        }
    }
}
