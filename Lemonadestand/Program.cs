﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game mygame = new Game();
            mygame.StartGame();
            //Customer mycustomer = new Customer();
            //mycustomer.CustomersToday();
            //mycustomer.DetermineWillBuy();

            Console.ReadKey();
        }
    }
}
