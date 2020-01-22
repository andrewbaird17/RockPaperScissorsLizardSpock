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
        public override void GestureChoice(string input)
        {
            ChosenGesture = input;       
        }
        public override void SetName()
        {
            name = "Computer";
        }
        public override string GetInput()
        {
            Console.WriteLine(name + "'s Turn");
            Random random = new Random();
            ChosenGesture = gestures[random.Next(0,5)].ToLower();
            return ChosenGesture;
        }
    }
}
