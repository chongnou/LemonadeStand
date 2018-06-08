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
        public Days days;
        public Player player;

        public Game()
        {
            weather = new Weather();
            days = new Days();
            player = new Player();
        }

        public void RunGame()
        {
            DisplayWelcome();

            weather.SetTemp();
            weather.SetCondition();
            DisplayWeather();

            Display7DayForcast();
            days.Display7DayForcast();

            PlayerChoosePitcherAndCups();
            player.ChoosePitchersAndCups();

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

            Console.WriteLine("The forcast for the next 7 days are: ");

        }

        public void PlayerChoosePitcherAndCups()
        {
            Console.Clear();
            Console.WriteLine("Start money:");
        }
    }
}
