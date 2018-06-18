using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Player
    {
        public Wallet wallet;
        public List<Cups> cups;

        public Player()
        {
            wallet = new Wallet();
            cups = new List<Cups>();
        }

        public Cups Cups
        {
            get => default(Cups);
            set
            {
            }
        }

        public void ChoosePitchersAndCups()
        {
            ChoosePitchers();
            ChooseCups();

            Console.ReadLine();
        }

        public void ChoosePitchers()
        {
            string userInput;

            Console.WriteLine("\nPlease choose how many pitchers you want to purchase. 1 pitcher = $2");
            Console.WriteLine("7 cups = 1 pitcher.");
            userInput = Console.ReadLine();


            if (userInput == "1")
            {
                Console.WriteLine("Cost = $2");
                wallet.money -= 2;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }

            }
            else if (userInput == "2")
            {
                Console.WriteLine("Cost = $4");
                wallet.money -= 4;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }

            }
            else if (userInput == "3")
            {
                Console.WriteLine("Cost = $6");
                wallet.money -= 6;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }

            }
            else if (userInput == "4")
            {
                Console.WriteLine("Cost = $8");
                wallet.money -= 8;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }

            }
            else if (userInput == "5")
            {
                Console.WriteLine("Cost = $10");
                wallet.money -= 10;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }

            }
            else if (userInput == "6")
            {
                Console.WriteLine("Cost = $12");
                wallet.money -= 12;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }

            }
            else if (userInput == "7")
            {
                Console.WriteLine("Cost = $14");
                wallet.money -= 14;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }

            }
            else if (userInput == "8")
            {
                Console.WriteLine("Cost = $16");
                wallet.money -= 16;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else if (userInput == "9")
            {
                Console.WriteLine("Cost = $18");
                wallet.money -= 18;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else if (userInput == "10")
            {
                Console.WriteLine("Cost = $20");
                wallet.money -= 20;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else
            {
                Console.WriteLine("Invalid Input, try again.");
            }
        }

        public void ChooseCups()
        {
            Console.WriteLine("\nChoose how many cups you want to purchase. 1 cup = 10¢");

            string userInput;

            userInput = Console.ReadLine();


            if (userInput == "1")
            {
                Console.WriteLine("Cost = 10¢");
                wallet.money -= .10;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }

            }
            else if (userInput == "2")
            {
                Console.WriteLine("Cost = 20¢");
                wallet.money -= .20;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Cost = 30¢");
                wallet.money -= .30;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Cost = 40¢");
                wallet.money -= .40;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else if (userInput == "5")
            {
                Console.WriteLine("Cost = 50¢");
                wallet.money -= .50;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else if (userInput == "6")
            {
                Console.WriteLine("Cost = 60¢");
                wallet.money -= .60;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else if (userInput == "7")
            {
                Console.WriteLine("Cost = 70¢");
                wallet.money -= .70;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }

            }
            else if (userInput == "8")
            {
                Console.WriteLine("Cost = 80¢");
                wallet.money -= .80;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else if (userInput == "9")
            {
                Console.WriteLine("Cost = 90¢");
                wallet.money -= .90;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else if (userInput == "10")
            {
                Console.WriteLine("Cost = $1");
                wallet.money -= 1;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else if (userInput == "11")
            {
                Console.WriteLine("Cost = $1.10");
                wallet.money -= 1.10;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else if (userInput == "12")
            {
                Console.WriteLine("Cost = $1.20");
                wallet.money -= 1.20;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else if (userInput == "13")
            {
                Console.WriteLine("Cost = $1.30");
                wallet.money -= 1.30;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else if (userInput == "14")
            {
                Console.WriteLine("Cost = $1.40");
                wallet.money -= 1.40;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else
            {
                Console.WriteLine("Try again.");
            }
        }

        public void MakeLemonade()
        {
            string userInput;

            Console.WriteLine("\nFirst, we have to make the lemonade!");
            Console.WriteLine("It takes 2 lemons, 4 sugars, and 4 ice to make a pitcher of lemonade.");
            Console.WriteLine("1 lemon = 15¢. 1 sugar = 5¢. 1 ice = 10¢.");
            Console.WriteLine("Cost to make 1 lemonade pitcher = 90¢. 2 = $1.80. 3 = $2.70. 4 = $3.60. 5 = $4.50.");
            Console.WriteLine("Starting money: $" + wallet.money);
            Console.WriteLine("\nHow much lemonade pitcher(s) do you want to make? Remember to save enough money to buy pitchers and cups!");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("Cost = 90¢");
                wallet.money -= .90;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Cost = $1.80");
                wallet.money -= 1.80;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Cost = $2.70");
                wallet.money -= 2.80;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Cost = $3.60");
                wallet.money -= 3.60;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else if (userInput == "5")
            {
                Console.WriteLine("Cost = $4.50");
                wallet.money -= 4.50;
                Console.WriteLine("Money left: $" + wallet.money);
                bool ifBankrupt = wallet.CheckIfBankrupt();
                if (ifBankrupt == true)
                {
                    ChoosePitchers();
                }
            }
            else
            {
                Console.WriteLine("Invalid Input, try again.");
            }
        }

        public void SetPrice()
        {
            double userInput;

            Console.WriteLine("Set the price for how many lemonade cups you want to sell!");
            userInput = double.Parse(Console.ReadLine());
            for(int i = 0; i < cups.Count; i++)
            {
                cups[i].priceToSell = userInput;

            }
        }
    }
}
