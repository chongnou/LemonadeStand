﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Days
    {
        Random rnd = new Random();

        public Days()
        {

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

        }

        public void Monday()
        {
            string temperature = "";
            string condition = "";
            
            int randomNumber = rnd.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    temperature = "Hot";
                    break;
                case 2:
                    temperature = "Warm";
                    break;
                case 3:
                    temperature = "Cold";
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
                    temperature = "Hot";
                    break;
                case 2:
                    temperature = "Warm";
                    break;
                case 3:
                    temperature = "Cold";
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
                    temperature = "Hot";
                    break;
                case 2:
                    temperature = "Warm";
                    break;
                case 3:
                    temperature = "Cold";
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
                    temperature = "Hot";
                    break;
                case 2:
                    temperature = "Warm";
                    break;
                case 3:
                    temperature = "Cold";
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
                    temperature = "Hot";
                    break;
                case 2:
                    temperature = "Warm";
                    break;
                case 3:
                    temperature = "Cold";
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
                    temperature = "Hot";
                    break;
                case 2:
                    temperature = "Warm";
                    break;
                case 3:
                    temperature = "Cold";
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
                    temperature = "Hot";
                    break;
                case 2:
                    temperature = "Warm";
                    break;
                case 3:
                    temperature = "Cold";
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
