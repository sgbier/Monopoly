using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTest
{
    [TestClass]
    public class LandingOnGoTest
    {
        [TestMethod]
        public void LandingOnGoTest1()
        {
            Player p1 = new Player("Sarah");

            double expected = p1.balance + 200.0;

            p1.position = 31;

            p1.move(9);

            double actual = p1.balance;

            Assert.AreEqual(expected, actual, "Player did not receive $200 when landing on Go.");
        }

        [TestMethod]
        public void LandingOnGoTest2()
        {
            Player p1 = new Player("Sarah");

            double expected = p1.balance;

            p1.position = 31;

            p1.move(3);

            double actual = p1.balance;

            Assert.AreEqual(expected, actual, "Player's balance changed when landing on a normal location.");
        }

    }
}
