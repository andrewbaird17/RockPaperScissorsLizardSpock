using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSLS;

namespace RPSLSTest
{
    [TestClass]
    public class HumanTest
    {

        [TestMethod]
        public void GestureChoice_InputRock_ReturnRock()
        {
            //Arrange
            Player human = new Human();
            string expected = "rock";
            string actual;

            //Act
            human.GestureChoice("rock");
            actual = human.ChosenGesture;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
