﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    class UserInterface
    {
        // Member Variables
        
        //Constructor
        
        //Member Methods
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static string GetUserInput()
        {
            return Console.ReadLine();
        }
    }
}
