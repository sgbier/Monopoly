using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTest
{
    [TestClass]
    public class PlayerMovementTest
    {
        [TestMethod]
        public void PlayerMovementTest1()
        {
            int expected = 7;

            Player p1 = new Player("Sarah");
            p1.move(7);

            int actual = p1.position;

            Assert.AreEqual(expected, actual, "Player movement incorrect.");
        }


        [TestMethod]
        public void PlayerMovementTest2()
        {
            int expected = 5;

            Player p1 = new Player("Sarah");
            p1.position = 39;
            p1.move(6);

            int actual = p1.position;

            Assert.AreEqual(expected, actual, "Player movement incorrect.");
        }
    }
}
