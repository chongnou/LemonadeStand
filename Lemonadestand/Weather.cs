using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Weather
    {
        public string temperature;
        public string condition;


        public Weather()
        {

        }

        public void SetTemp()
        {
            Random rnd = new Random();
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
        }

        public void SetCondition()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 4);

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
        }
    }
}
