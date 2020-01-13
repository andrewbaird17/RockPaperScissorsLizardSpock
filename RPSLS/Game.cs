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

        //Constructor
        public Game()
        {
            
        }
        //Member Methods (CAN DO)
        public void RunGame()
        {
            GameInstructions();
            string choice = ChooseGamemode();
        }

        public void GameInstructions()
        {
            Console.WriteLine("Welcome! You have chosen to play a game of Rock, Paper, Scissors, Lizard, Spock \nThe goal of the game is to beat a computer or another player over multiple rounds. \nA winner is declarecd once one of the players has successfully won three rounds.");
            Console.WriteLine("Please select a gamemode to begin!");
            Console.ReadLine();
        }
        public string ChooseGamemode()
        {
            string choice;
            do
            {
                Console.WriteLine("Pick an option:\n1) Human\n2) Computer");
                choice = Console.ReadLine();
            } while (choice != "1" && choice != "2");
            return choice;
        }

        public void BadInput()
        {

        }

    }
}
