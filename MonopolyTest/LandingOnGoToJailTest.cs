using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTest
{
    [TestClass]
    public class LandingOnGoToJailTest
    {
        [TestMethod]
        public void LandingOnGoToJailTest1()
        {
            Player p1 = new Player("Sarah");

            int expectedPosition = 10;
            double expectedBalance = p1.balance;

            p1.position = 22;

            p1.move(8);

            int actualPosition = p1.position;
            double actualBalance = p1.balance;

            Assert.AreEqual(expectedPosition, actualPosition, "Player did not end on Just Visiting when landing on Go To Jail.");
            Assert.AreEqual(expectedBalance, actualBalance, "Player's balance changed when landing on Go To Jail and moving to Just Visiting.");
        }


        [TestMethod]
        public void LandingOnGoToJailTest2()
        {
            Player p1 = new Player("Sarah");

            int expectedPosition = 33;
            double expectedBalance = p1.balance;

            p1.position = 22;

            p1.move(11);

            int actualPosition = p1.position;
            double actualBalance = p1.balance;

            Assert.AreEqual(expectedPosition, actualPosition, "Player did not end up where they should after passing Go To Jail.");
            Assert.AreEqual(expectedBalance, actualBalance, "Player's balance changed when passing Go To Jail.");
        }
    }
}
