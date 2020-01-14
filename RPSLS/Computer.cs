using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        //Member Variables (HAS A)
        
        //Constructor
        public Computer()
        {

        }
        //Member Methods (CAN DO)
        public override void GestureChoice()
        {
            Random random = new Random();
            ChosenGesture = gestures[random.Next(5)].ToLower();       
        }
        public override void SetName()
        {
            name = "Computer";
        }
    }
}
