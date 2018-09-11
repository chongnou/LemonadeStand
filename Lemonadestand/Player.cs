using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    class Player
    {
        // Member Variables
        public string name;
        public string nameInput;

        //Constructor
        public Player()
        {

        }
        
        //Methods
        public void GetPlayerName()
        {
            UserInterface.DisplayMessage("What is your Name? ");

            nameInput = UserInterface.GetUserInput();
            name = nameInput.ToUpper();
        }
    }
}
