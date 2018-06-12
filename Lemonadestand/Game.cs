using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Game
    {
        public Weather weather;
        public Forcast forcast;
        public Player player;
        public List<Customer> customers;
        public Items items;

        public Game()
        {
            weather = new Weather();
            forcast = new Forcast();
            player = new Player();
            customers = new List<Customer>();
            items = new Items();
        }

        public void RunGame()
        {
            
            DisplayWelcome();

            weather.SetTemp();
            weather.SetCondition();
            DisplayWeather();

            Display7DayForcast();
            forcast.Display7DayForcast();
            
            player.MakeLemonade();

            DisplayTodayForcast();
            
            player.ChoosePitchersAndCups();
            player.SetPrice();

            GenerateCustomers();
            Customer customer = new Customer();
            customer.CustomerBuying(weather, customers, player);
            
        }

        public void DisplayWelcome()
        {
            Console.WriteLine("You are playing Lemonade Stand!");
            Console.WriteLine("Try to make as much money as you can!");
            Console.ReadLine();
            Console.Clear();

        }

        public void DisplayWeather()
        {
            Console.WriteLine("Today's forcast is: " + weather.temperature + " and " + weather.condition);
            Console.ReadLine();

        }
        
        public void Display7DayForcast()
        {

            Console.WriteLine("The forcast for the next 7 days are: \n");

        }

        public void DisplayTodayForcast()
        {
            Console.WriteLine("\nToday's forcast: " + weather.temperature + " and " + weather.condition);
        }

        public void GenerateCustomers()
        {
            for(int i = 0; i < 50; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
            }
        }


    }
}
