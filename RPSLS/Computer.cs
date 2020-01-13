using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        //Member Variables (HAS A)
        
        //Constructor
        public Computer()
        {
        }
        //Member Methods (CAN DO)
        protected override string GestureChoice()
        {
            Random random = new Random();
            string compGesture;
            compGesture = gestures[random.Next(gestures.Count + 1)];
            return compGesture;
        }

    }
}
