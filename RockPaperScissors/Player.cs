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
            //this.choice = Console.ReadLine();

            string enteredChoice = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    enteredChoice += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(enteredChoice))
                    {
                        // remove one character from the list of password characters
                        enteredChoice = enteredChoice.Substring(0, enteredChoice.Length - 1);
                        // get the location of the cursor
                        int pos = Console.CursorLeft;
                        // move the cursor to the left by one character
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        // replace it with space
                        Console.Write(" ");
                        // move the cursor to the left by one character again
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }
            Console.WriteLine();
            this.choice = enteredChoice;
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
