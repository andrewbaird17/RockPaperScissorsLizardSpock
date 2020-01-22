using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        //Member Variables (HAS A)

        //Constructor
        public Human()
        {

        }

        //Member Methods (CAN DO)
        public override void GestureChoice(string input)
        {
            // validate the user choice below
            switch (input)
            {
                case "rock":
                    ChosenGesture = "rock";
                    break;
                case "paper":
                    ChosenGesture = "paper";
                    break;
                case "scissors":
                    ChosenGesture = "scissors";
                    break;
                case "lizard":
                    ChosenGesture = "lizard";
                    break;
                case "spock":
                    ChosenGesture = "spock";
                    break;
                default:
                    Console.WriteLine("Please enter a valid gesture");
                    Console.Clear();
                    GetInput();
                    break;
            }
        }
        public override string GetInput()
        {
            Console.WriteLine(name + "'s Turn");
            Console.WriteLine("Please choose an option: \nRock \nPaper \nScissors \nLizard \nSpock");
            ChosenGesture = Console.ReadLine().ToLower();
            return ChosenGesture;
        }
        public override void SetName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
        
    }
}

