using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    class Program
    {
        public Game Game
        {
            get => default(Game);
            set
            {
            }
        }

        static void Main(string[] args)
        {
            Game rungame = new Game();
            rungame.RunGame();
        }
    }
}
