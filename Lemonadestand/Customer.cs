using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Customer
    {
        bool boughtLemonade = false;
        
        public Customer()
        {
            

        }

        public void CustomerBuying(Weather weather, List<Customer> customers)
        {
            ChanceToBuyTemperature(weather, customers);
            ChanceToBuyCondition(weather, customers);

            Console.ReadLine();
        }

        

        public void ChanceToBuyTemperature(Weather weather, List<Customer> customers)
        {

            if (weather.temperature == "90°")
            {
                for (int i = 0; i <= customers.Count; i++)
                {
                    //customer buys lemonade
                    //check if player ran out of cups

                    customers[i].boughtLemonade = true;
                }
            }
            else if (weather.temperature == "70°")
            {
                for (int i = 0; i <= customers.Count; i++);
            }
            else if (weather.temperature == "50°")
            {
                for (int i = 0; i <= customers.Count; i++);
            }
        }

        public void ChanceToBuyCondition(Weather weather, List<Customer> customers)
        {

            if (weather.condition == "Sunny")
            {
                for (int i = 0; i <= customers.Count; i++);
            }
            else if (weather.condition == "Cloudy")
            {
                for (int i = 0; i <= customers.Count; i++);
            }
            else if (weather.condition == "Raining")
            {
                for (int i = 0; i <= customers.Count; i++);
            }
        }
        
        public void Buy()
        {

        }
    }
}
