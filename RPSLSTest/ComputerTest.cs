using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSLS;

namespace RPSLSTest
{
    [TestClass]
    public class ComputerTest
    {
        [TestMethod]
        public void GestureChoice_InputRock_ReturnRock()
        {
            //Arrange
            Player computer = new Computer();
            string expected = "rock";
            string actual;
            //Act
            computer.GestureChoice("rock");
            actual = computer.ChosenGesture;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
