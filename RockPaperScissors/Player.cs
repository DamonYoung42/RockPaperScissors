using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player
    {
        string name;
        string choice;

        public Player(string name)
        {

            this.name = name;
        }

        public void SetChoice()
        {
            Console.WriteLine("What is your choice -- Rock, Paper or Scissors?");
            this.choice = Console.ReadLine();
        }

        public string GetChoice()
        {
            return this.choice;
        }

        public string GetName()
        {
            return this.name;
        }

        public string SetComputerHand()
        {
            Random randomNumber = new Random(DateTime.Now.Millisecond);
            Double randomChoice = randomNumber.NextDouble();

            if (randomChoice <= .33)
            {
                return this.choice = "Rock";
            }
            else if (randomChoice <= .67)
            {
                return this.choice = "Paper";
            }
            else
            {
                return this.choice = "Scissors";
            }
        }


    }
}
