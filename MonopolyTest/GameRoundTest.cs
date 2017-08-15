using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTest
{
    [TestClass]
    public class GameRoundTest
    {
        [TestMethod]
        public void GameRoundTest1()
        {
            int expected = 20;

            Game game1 = new Game();

            game1.addPlayer("Horse");
            game1.addPlayer("Car");

            game1.play();

            int actual = game1.roundsPlayed;

            Assert.AreEqual(expected, actual, "Total number of rounds incorrect.");
        }


        [TestMethod]
        public void GameRoundTest2()
        {
            int expected = 20;

            Game game1 = new Game();

            game1.addPlayer("Horse");
            game1.addPlayer("Car");

            game1.play();

            int actual = game1.players[0].roundsPlayed;

            Assert.AreEqual(expected, actual, "Player 1 number of rounds incorrect.");
        }

        [TestMethod]
        public void GameRoundTest3()
        {
            int expected = 20;

            Game game1 = new Game();

            game1.addPlayer("Horse");
            game1.addPlayer("Car");

            game1.play();

            int actual = game1.players[1].roundsPlayed;

            Assert.AreEqual(expected, actual, "Player 2 number of rounds incorrect.");
        }


        [TestMethod]
        public void GameRoundTest4()
        {
            Game game1 = new Game();

            game1.addPlayer("Horse");
            game1.addPlayer("Car");

            game1.play();

            // How to check that the order of the players stays the same??
        }
    }
}
