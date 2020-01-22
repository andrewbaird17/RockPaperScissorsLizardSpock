using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSLS;

namespace RPSLSTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void CompareChoices_P1IsRockP2IsScissors_P1Wins()
        {
            //Arrange
            Game game = new Game();
            Player player1 = new Computer();
            Player player2 = new Computer();
            player1.ChosenGesture = "rock";
            player2.ChosenGesture = "scissors";
            int actual;
            int expected = 1;
            //Act
            game.CompareChoices(player1, player2);
            actual = player1.roundWins;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
