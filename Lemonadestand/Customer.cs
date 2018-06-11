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

        double percent = 100;
        double temperatureProbability;
        double conditionProbability;

        public Customer()
        {

        }

        public void ChanceToBuyTemperature(Weather weather)
        {

            if (weather.temperature == "90°")
            {
                temperatureProbability = percent * 1.75;
            }
            else if (weather.temperature == "70°")
            {
                temperatureProbability = percent * 1.50;
            }
            else if (weather.temperature == "50°")
            {
                temperatureProbability = percent * 1.00;
            }
        }

        public void ChanceToBuyCondition(Weather weather)
        {
            Random rnd = new Random();

            if (weather.condition == "Sunny")
            {
                conditionProbability = percent * 1.85;
            }
            else if (weather.condition == "Cloudy")
            {
                conditionProbability = percent * 1.45;
            }
            else if (weather.condition == "Raining")
            {
                conditionProbability = percent * 1.00;
            }
        }

        public void CustomerChanceOfBuying()
        {

        }
    }
}
