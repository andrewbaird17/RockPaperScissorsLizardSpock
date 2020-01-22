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

        //[TestMethod]
        //public void GestureChoice_InputFlamingo_ReturnBlank()
        //{
        //    //Arrange
        //    Player human = new Human();
        //    string expected = "";
        //    string actual;

        //    //Act
        //    human.GestureChoice("");
        //    actual =  human.ChosenGesture;


        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
