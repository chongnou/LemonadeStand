using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Days
    {
        public Weather weather;

        public Days()
        {
            weather = new Weather();
            weather.SetTemp();
            weather.SetCondition();
        }
        
        public void Display7DayForcast()
        {

            Console.WriteLine("Monday: " + weather.temperature + " and " + weather.condition);
            Console.WriteLine("Tuesday: " + weather.temperature + " and " + weather.condition);
            Console.WriteLine("Wednesday: " + weather.temperature + " and " + weather.condition);
            Console.WriteLine("Thursday: " + weather.temperature + " and " + weather.condition);
            Console.WriteLine("Friday: " + weather.temperature + " and " + weather.condition);
            Console.WriteLine("Saturday: " + weather.temperature + " and " + weather.condition);
            Console.WriteLine("Sunday: " + weather.temperature + " and " + weather.condition);
            Console.ReadLine();

        }
    }
}
