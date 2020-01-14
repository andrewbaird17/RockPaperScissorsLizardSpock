using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //Member Variables (HAS A)
        public string ChosenGesture;
        public List<string> gestures;
        public int roundWins;
        public string name;


        //Constructor
        public Player()
        {
           gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
           roundWins = 0;
        }

        //Member Methods (CAN DO)

        public abstract void GestureChoice();

        public abstract void SetName();

    }
}
