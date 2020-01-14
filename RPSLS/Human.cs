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
        public override void GestureChoice()
        {
            Console.WriteLine("Please choose an option: \n Rock \n Paper \n Scissors \n Lizard \n Spock");
            ChosenGesture = Console.ReadLine().ToLower();

            // validate the user choice below
            switch (ChosenGesture)
            {
                case "rock":
                    break;
                case "paper":
                    break;
                case "scissors":
                    break;
                case "lizard":
                    break;
                case "spock":
                    break;
                default:
                    Console.WriteLine("Please enter a valid gesture");
                    Console.Clear();
                    GestureChoice();
                    break;
            }
        }
        public override void SetName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
        
    }
}

