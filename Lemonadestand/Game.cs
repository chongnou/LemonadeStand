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

        public Game()
        {
            weather = new Weather();
            days = new Days();
        }

        public void RunGame()
        {
            DisplayWelcome();

            weather.SetTemp();
            weather.SetCondition();
            DisplayWeather();

            Display7DayForcast();
            days.Display7DayForcast();

        }

        public void DisplayWelcome()
        {
            Console.WriteLine("You are playing Lemonade Stand!");
            Console.WriteLine("Try to make as much money as you can!");

        }

        public void DisplayWeather()
        {
            Console.WriteLine("\nToday's forcast is: " + weather.temperature + " and " + weather.condition);
            Console.ReadLine();

        }
        
        public void Display7DayForcast()
        {

            Console.WriteLine("The forcast for the next 7 days are: ");

        }
    }
}
