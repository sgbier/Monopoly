using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTest
{
    [TestClass]
    public class LandingOnLuxuryTaxTest
    {
        [TestMethod]
        public void LandingOnLuxuryTaxTest1()
        {
            Player p1 = new Player("Sarah");
            p1.balance = 1800;

            double expected = p1.balance - 75;

            p1.position = 35;

            p1.move(3);

            double actual = p1.balance;

            Assert.AreEqual(expected, actual, "Player's balance did not decrease correctly when landing on Luxury Tax.");
        }

        [TestMethod]
        public void LandingOnLuxuryTaxTest2()
        {
            Player p1 = new Player("Sarah");
            p1.balance = 1800;

            double expected = p1.balance;

            p1.position = 35;

            p1.move(4);

            double actual = p1.balance;

            Assert.AreEqual(expected, actual, "Player's balance decreased when passing Luxury Tax.");
        }
    }
}
