using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        Player playerOne;
        Player computerPlayer;
        bool continuePlaying;

        public Game()

        {
            computerPlayer = new Player("computer");
            computerPlayer.SetComputerHand();
            continuePlaying = true;

        }

        public void RunGame()
        {
            SetUser();

            while (continuePlaying) {
                playerOne.SetChoice();
                string result = CompareHands();
                Console.WriteLine(result);
                Console.WriteLine("Do you want to play again?");
                if (Console.ReadLine().ToUpper() == "N")
                {
                    continuePlaying = false;
                }
            }

        }

        public Player SetUser()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors");
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            return playerOne = new Player(userName);

        }

        public string CompareHands()
        {
            if (playerOne.GetChoice().ToLower() == computerPlayer.GetChoice().ToLower())
            {
                return "Both players chose the same " + playerOne.GetChoice().ToLower() + " . It's a tie!";
            }
            else
            {
                if (playerOne.GetChoice().ToLower() == "scissors")
                {
                    if (computerPlayer.GetChoice().ToLower() == "paper")
                    {
                        return "Scissors cut paper: " + playerOne.GetName() + " wins!";
                    }
                    else
                    {
                        return "Rock beats scissors: " + computerPlayer.GetName() + " wins!";
                    }
                }
                else if (playerOne.GetChoice().ToLower() == "rock")
                {
                    if (computerPlayer.GetChoice().ToLower() == "scissors")
                    {
                        return "Rock beats scissors: " + playerOne.GetName() + " wins!";
                    }
                    else
                    {
                        return "Paper covers rock: " + computerPlayer.GetName() + " wins!";
                    }
                }
                else if (playerOne.GetChoice().ToLower() == "paper")
                {
                    if (computerPlayer.GetChoice().ToLower() == "rock")
                    {
                        return "Paper covers rock: " + playerOne.GetName() + " wins!";
                    }
                    else
                    {
                        return "Scissors cut paper: " + computerPlayer.GetName() + " wins!";
                    }
                }
                else
                {
                    return "Winner could not be determined.";
                }
            }
        }


    }
}
