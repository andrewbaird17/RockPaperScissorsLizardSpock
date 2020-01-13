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
        public Player player;
        public int counter;

        //Constructor
        public Game()
        {
            counter = 1;
        }
        //Member Methods (CAN DO)
        public void RunGame()
        {
            GameInstructions();
            string choice = ChooseGamemode();
            Human player1 = new Human();
            switch (choice)
            {
                case "1":
                    GamewithComp();
                    break;
                case "2":
                    TwoPlayerGame();
                    break;
                default:
                    break;
            }
        }

        public void GameInstructions()
        {
            Console.WriteLine("Welcome! You have chosen to play a game of Rock, Paper, Scissors, Lizard, Spock \nThe goal of the game is to beat a computer or another player over multiple rounds. \nA winner is declarecd once one of the players has successfully won three rounds.");
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
                if (choice != "1" | choice != "2")
                {
                    Console.WriteLine("Please enter a valid choice to continue to rest of game");
                }
            } while (choice != "1" && choice != "2");
            return choice;
        }

        public void GamewithComp()
        {
            Computer comp = new Computer();
        }

        public void TwoPlayerGame()
        {
            Human player2 = new Human();
        }
    }
}
