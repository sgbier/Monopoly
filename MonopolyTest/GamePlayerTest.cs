using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTest
{
    [TestClass]
    public class GamePlayerTest
    {
        [TestMethod]
        public void GamePlayerTest1()
        {
            Game game1 = new Game();

            game1.addPlayer("Horse");
            game1.addPlayer("Car");

            // What should I check here??
        }


        [TestMethod]
        public void GamePlayerTest2()
        {
            bool expected = false;

            Game game1 = new Game();

            game1.addPlayer("Horse");

            bool actual = game1.play();

            Assert.AreEqual(expected, actual, "Check for less than 2 players failed.");
        }


        [TestMethod]
        public void GamePlayerTest3()
        {
            bool expected = false;

            Game game1 = new Game();

            game1.addPlayer("Horse");
            game1.addPlayer("Car");
            game1.addPlayer("Dog");
            game1.addPlayer("Cat");
            game1.addPlayer("Phone");
            game1.addPlayer("Paper");
            game1.addPlayer("Pen");
            game1.addPlayer("Staple");
            game1.addPlayer("Picture");

            bool actual = game1.play();

            Assert.AreEqual(expected, actual, "Check for more than 8 players failed.");
        }
    }
}
