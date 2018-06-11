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
        public Items items;

        public Game()
        {
            weather = new Weather();
            forcast = new Forcast();
            player = new Player();
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

            DisplayWallet();

            PlayerChoosePitcherAndCups();
            player.ChoosePitchersAndCups();

            

            //sell lemonade
            forcast = new Forcast();



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

        public void DisplayWallet()
        {
            Console.WriteLine("\nToday's forcast: " + weather.temperature + " and " + weather.condition);
        }

        public void PlayerChoosePitcherAndCups()
        {

        }
    }
}
