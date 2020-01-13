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
            Console.WriteLine("Please choose an option: \n1: Rock \n2: Paper \n3: Scissors \n4: Lizard \n5: Spock");
            ChosenGesture = Console.ReadLine().ToLower();

            // validate the user choice below
            //if (ChosenGesture != "rock" || ChosenGesture != "paper" || ChosenGesture != "scissors" || ChosenGesture != "lizard" || ChosenGesture != "spock")
            //foreach(string gesture in gestures)
            //{
            //    if (ChosenGesture != gesture)
            //    Console.WriteLine("Please enter a valid choice to continue to rest of game");
            //    Console.ReadLine();
            //    GestureChoice();
            //}

        }
    }
}

