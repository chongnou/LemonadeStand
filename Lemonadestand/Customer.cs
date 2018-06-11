using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Customer
    {
        public Weather weather;
        

        public Customer()
        {
            weather = new Weather();

        }

        public void CustomerBuying()
        {
            ChanceToBuyTemperature();
            ChanceToBuyCondition();
        }

        public void ChanceToBuyTemperature()
        {

            if (weather.temperature == "90°")
            {

            }
            else if (weather.temperature == "70°")
            {

            }
            else if (weather.temperature == "50°")
            {

            }
        }

        public void ChanceToBuyCondition()
        {
            Random rnd = new Random();

            if (weather.condition == "Sunny")
            {

            }
            else if (weather.condition == "Cloudy")
            {

            }
            else if (weather.condition == "Raining")
            {

            }
        }

        public void CustomerChanceOfBuying()
        {

        }
    }
}
