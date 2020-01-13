using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        //Member Variables (HAS A)
        protected Human human;
        protected Computer computer;

        //Constructor
        public Player()
        {
            List<string> gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }

        //Member Methods (CAN DO)

        protected abstract void GestureChoice();

    }
}
