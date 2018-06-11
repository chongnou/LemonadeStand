using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Days
    {
        Random rnd = new Random();
        public Weather weather;

        // make temp and conditon appear for the game day

        public Days()
        {
            weather = new Weather();
            weather.SetCondition();
            weather.SetTemp();
        }
        
        public void Display7DayForcast()
        {
            Monday();
            Tuesday();
            Wednesday();
            Thursday();
            Friday();
            Saturday();
            Sunday();

            Console.ReadLine();
            Console.Clear();

        }

        public void Monday()
        {
            string temperature = "";
            string condition = "";
            
            int randomNumber = rnd.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    temperature = "90°";
                    break;
                case 2:
                    temperature = "70°";
                    break;
                case 3:
                    temperature = "50°";
                    break;
            }

            switch (randomNumber)
            {
                case 1:
                    condition = "Sunny";
                    break;
                case 2:
                    condition = "Cloudy";
                    break;
                case 3:
                    condition = "Raining";
                    break;
            }

            Console.WriteLine("Monday: " + temperature + " and " + condition);
        }

        public void Tuesday()
        {
            string temperature = "";
            string condition = "";
            
            int randomNumber = rnd.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    temperature = "90°";
                    break;
                case 2:
                    temperature = "70°";
                    break;
                case 3:
                    temperature = "50°";
                    break;
            }

            switch (randomNumber)
            {
                case 1:
                    condition = "Sunny";
                    break;
                case 2:
                    condition = "Cloudy";
                    break;
                case 3:
                    condition = "Raining";
                    break;
            }

            Console.WriteLine("Tuesday: " + temperature + " and " + condition);
        }

        public void Wednesday()
        {
            string temperature = "";
            string condition = "";
            
            int randomNumber = rnd.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    temperature = "90°";
                    break;
                case 2:
                    temperature = "70°";
                    break;
                case 3:
                    temperature = "50°";
                    break;
            }

            switch (randomNumber)
            {
                case 1:
                    condition = "Sunny";
                    break;
                case 2:
                    condition = "Cloudy";
                    break;
                case 3:
                    condition = "Raining";
                    break;
            }

            Console.WriteLine("Wednesday: " + temperature + " and " + condition);
        }

        public void Thursday()
        {
            string temperature = "";
            string condition = "";
            
            int randomNumber = rnd.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    temperature = "90°";
                    break;
                case 2:
                    temperature = "70°";
                    break;
                case 3:
                    temperature = "50°";
                    break;
            }

            switch (randomNumber)
            {
                case 1:
                    condition = "Sunny";
                    break;
                case 2:
                    condition = "Cloudy";
                    break;
                case 3:
                    condition = "Raining";
                    break;
            }

            Console.WriteLine("Thursday: " + temperature + " and " + condition);
        }

        public void Friday()
        {
            string temperature = "";
            string condition = "";
            
            int randomNumber = rnd.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    temperature = "90°";
                    break;
                case 2:
                    temperature = "70°";
                    break;
                case 3:
                    temperature = "50°";
                    break;
            }

            switch (randomNumber)
            {
                case 1:
                    condition = "Sunny";
                    break;
                case 2:
                    condition = "Cloudy";
                    break;
                case 3:
                    condition = "Raining";
                    break;
            }

            Console.WriteLine("Friday: " + temperature + " and " + condition);
        }
        public void Saturday()
        {
            string temperature = "";
            string condition = "";
            
            int randomNumber = rnd.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    temperature = "90°";
                    break;
                case 2:
                    temperature = "70°";
                    break;
                case 3:
                    temperature = "50°";
                    break;
            }

            switch (randomNumber)
            {
                case 1:
                    condition = "Sunny";
                    break;
                case 2:
                    condition = "Cloudy";
                    break;
                case 3:
                    condition = "Raining";
                    break;
            }

            Console.WriteLine("Saturday: " + temperature + " and " + condition);
        }

        public void Sunday()
        {
            string temperature = "";
            string condition = "";
            
            int randomNumber = rnd.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    temperature = "90°";
                    break;
                case 2:
                    temperature = "70°";
                    break;
                case 3:
                    temperature = "50°";
                    break;
            }

            switch (randomNumber)
            {
                case 1:
                    condition = "Sunny";
                    break;
                case 2:
                    condition = "Cloudy";
                    break;
                case 3:
                    condition = "Raining";
                    break;
            }

            Console.WriteLine("Sunday: " + temperature + " and " + condition);
        }
    }
}
