using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //Member Variables (HAS A)

        public Player Player1;
        public Player Player2;
        public int totalpointsWin;

        //Constructor
        public Game()
        {

        }
        //Member Methods (CAN DO)
        public void RunGame()
        {
            GameInstructions();
            SetGameMode();
            DetermineRoundWins();
            GamePlay();
            DetermineWinner();
            PlayAgain();
        }

        public void GameInstructions()
        {
            Console.WriteLine("Welcome! You have chosen to play a game of Rock, Paper, Scissors, Lizard, Spock \nThe goal of the game is to beat a computer or another player over multiple rounds. \nA winner is declared once one of the players has successfully won a certain amount of rounds.");
            Console.WriteLine("Here are how each round is determined to declare a winner for that round: \n" +
                "Rock crushes Scissors \nScissors cuts Paper \nPaper covers Rock \nRock crushes Lizard \nLizard poisons Spock \nSpock smashes Scissors \nScissors decapitates Lizard \nLizard eats Paper \nPaper disproves Spock\nSpock vaporizes Rock");
            Console.WriteLine(" \nPlease select a gamemode to begin!");
            Console.ReadLine();
            Console.Clear();
        }
        public string ChooseGamemode()
        {
            // get user's choice of player 
            string choice;
            do
            {
                Console.WriteLine("Pick an option:\n1) Human vs Computer \n2) Human vs Human");
                choice = Console.ReadLine();
                Console.Clear();
                // make user choose one of the options to continue 
                if (choice != "1" || choice != "2")
                {
                    Console.WriteLine("Please enter a valid choice to continue to rest of game");
                }
            } while (choice != "1" && choice != "2");
            return choice;
        }

        public void SetGameMode()
        {
            string choice = ChooseGamemode();
            switch (choice)
            {
                case "1":
                    Player1 = new Human();
                    Player2 = new Computer();
                    Player1.SetName();
                    Player2.SetName();
                    break;
                case "2":
                    Player1 = new Human();
                    Player2 = new Human();
                    Player1.SetName();
                    Player2.SetName();
                    break;
                default:
                    break;
            }
        }

        public void GamePlay()
        {
            do
            {                
                Player1.GestureChoice();
                Console.Clear();
                Player2.GestureChoice();
                CompareChoices();
            } while (Player1.roundWins != totalpointsWin && Player2.roundWins != totalpointsWin);
        }

        public void CompareChoices()
        {
            if (Player1.ChosenGesture == "rock")
            {
                if (Player2.ChosenGesture == "rock")
                {
                    Console.WriteLine("Player 1 chose " + Player1.ChosenGesture + " and Player 2 chose " + Player2.ChosenGesture);
                    Console.WriteLine("There is no winner this round. Pick new choices.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (Player2.ChosenGesture == "paper" || Player2.ChosenGesture == "spock")
                {
                    Console.WriteLine("Player 1 chose " + Player1.ChosenGesture + " and Player 2 chose " + Player2.ChosenGesture);
                    Console.WriteLine("Player 2 wins this round");
                    Player2.roundWins += 1;
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (Player2.ChosenGesture == "scissors" || Player2.ChosenGesture == "lizard")
                {
                    Console.WriteLine("Player 1 chose " + Player1.ChosenGesture + " and Player 2 chose " + Player2.ChosenGesture);
                    Console.WriteLine("Player 1 wins this round");
                    Player1.roundWins += 1;
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            if (Player1.ChosenGesture == "paper")
            {
                if (Player2.ChosenGesture == "paper")
                {
                    Console.WriteLine("Player 1 chose " + Player1.ChosenGesture + " and Player 2 chose " + Player2.ChosenGesture);
                    Console.WriteLine("There is no winner this round. Pick new choices.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (Player2.ChosenGesture == "lizard" || Player2.ChosenGesture == "scissors")
                {
                    Console.WriteLine("Player 1 chose " + Player1.ChosenGesture + " and Player 2 chose " + Player2.ChosenGesture);
                    Console.WriteLine("Player 2 wins this round");
                    Player2.roundWins += 1;
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (Player2.ChosenGesture == "rock" || Player2.ChosenGesture == "spock")
                {
                    Console.WriteLine("Player 1 chose " + Player1.ChosenGesture + " and Player 2 chose " + Player2.ChosenGesture);
                    Console.WriteLine("Player 1 wins this round");
                    Player1.roundWins += 1;
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            if (Player1.ChosenGesture == "scissors")
            {
                if (Player2.ChosenGesture == "scissors")
                {
                    Console.WriteLine("Player 1 chose " + Player1.ChosenGesture + " and Player 2 chose " + Player2.ChosenGesture);
                    Console.WriteLine("There is no winner this round. Pick new choices.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (Player2.ChosenGesture == "rock" || Player2.ChosenGesture == "spock")
                {
                    Console.WriteLine("Player 1 chose " + Player1.ChosenGesture + " and Player 2 chose " + Player2.ChosenGesture);
                    Console.WriteLine("Player 2 wins this round");
                    Player2.roundWins += 1;
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (Player2.ChosenGesture == "paper" || Player2.ChosenGesture == "lizard")
                {
                    Console.WriteLine("Player 1 chose " + Player1.ChosenGesture + " and Player 2 chose " + Player2.ChosenGesture);
                    Console.WriteLine("Player 1 wins this round");
                    Player1.roundWins += 1;
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            if (Player1.ChosenGesture == "lizard")
            {
                if (Player2.ChosenGesture == "lizard")
                {
                    Console.WriteLine("Player 1 chose " + Player1.ChosenGesture + " and Player 2 chose " + Player2.ChosenGesture);
                    Console.WriteLine("There is no winner this round. Pick new choices.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (Player2.ChosenGesture == "rock" || Player2.ChosenGesture == "scissors")
                {
                    Console.WriteLine("Player 1 chose " + Player1.ChosenGesture + " and Player 2 chose " + Player2.ChosenGesture);
                    Console.WriteLine("Player 2 wins this round");
                    Player2.roundWins += 1;
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (Player2.ChosenGesture == "paper" || Player2.ChosenGesture == "spock")
                {
                    Console.WriteLine("Player 1 chose " + Player1.ChosenGesture + " and Player 2 chose " + Player2.ChosenGesture);
                    Console.WriteLine("Player 1 wins this round");
                    Player1.roundWins += 1;
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            if (Player1.ChosenGesture == "spock")
            {
                if (Player2.ChosenGesture == "spock")
                {
                    Console.WriteLine("Player 1 chose " + Player1.ChosenGesture + " and Player 2 chose " + Player2.ChosenGesture);
                    Console.WriteLine("There is no winner this round. Pick new choices.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (Player2.ChosenGesture == "paper" || Player2.ChosenGesture == "lizard")
                {
                    Console.WriteLine("Player 1 chose " + Player1.ChosenGesture + " and Player 2 chose " + Player2.ChosenGesture);
                    Console.WriteLine("Player 2 wins this round");
                    Player2.roundWins += 1;
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (Player2.ChosenGesture == "rock" || Player2.ChosenGesture == "scissors")
                {
                    Console.WriteLine("Player 1 chose " + Player1.ChosenGesture + " and Player 2 chose " + Player2.ChosenGesture);
                    Console.WriteLine("Player 1 wins this round");
                    Player1.roundWins += 1;
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        public void DetermineRoundWins()
        {
            Console.WriteLine("Pick how many round wins it takes to win");
            string userInput = Console.ReadLine();
            // validate totalpointswin to only take a number
            bool success = Int32.TryParse(userInput, out totalpointsWin);
            if (success)
            {
                totalpointsWin = Convert.ToInt32(userInput);
                Console.Clear();
            }
            else
            {
                DetermineRoundWins();
            }
        }
        public void DetermineWinner()
        {
            if (Player1.roundWins == totalpointsWin)
            {
                Console.WriteLine("Player 1 Wins!");
                Console.ReadLine();
            }
            else if (Player2.roundWins == totalpointsWin)
            {
                Console.WriteLine("Player 2 Wins!");
                Console.ReadLine();
            }
        }

        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play another game? Yes or No");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "yes":
                    RunGame();
                    break;
                case "no":
                    Console.WriteLine("Thank you for playing! Hit any key to EXIT.");
                    Console.ReadLine();
                    break;
                default:
                    PlayAgain();
                    break;
            }
        }
    }
}
