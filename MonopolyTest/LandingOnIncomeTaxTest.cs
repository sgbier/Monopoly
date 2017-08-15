using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTest
{
    [TestClass]
    public class LandingOnIncomeTaxTest
    {
        [TestMethod]
        public void LandingOnIncomeTaxTest1()
        {
            Player p1 = new Player("Sarah");

            double expected = 1800 - 180;

            p1.position = 0;
            p1.balance = 1800;

            p1.move(4);

            double actual = p1.balance;

            Assert.AreEqual(expected, actual, "Player's balance did not decrease correctly when landing on Income Tax.");
        }


        [TestMethod]
        public void LandingOnIncomeTaxTest2()
        {
            Player p1 = new Player("Sarah");

            double expected = 2200 - 200;

            p1.position = 0;
            p1.balance = 2200;

            p1.move(4);

            double actual = p1.balance;

            Assert.AreEqual(expected, actual, "Player's balance did not decrease correctly when landing on Income Tax.");
        }


        [TestMethod]
        public void LandingOnIncomeTaxTest3()
        {
            Player p1 = new Player("Sarah");

            double expected = 0;

            p1.position = 0;

            p1.move(4);

            double actual = p1.balance;

            Assert.AreEqual(expected, actual, "Player's balance did not decrease correctly when landing on Income Tax.");
        }


        [TestMethod]
        public void LandingOnIncomeTaxTest4()
        {
            Player p1 = new Player("Sarah");

            double expected = 2000 - 200;

            p1.position = 0;
            p1.balance = 2000;

            p1.move(4);

            double actual = p1.balance;

            Assert.AreEqual(expected, actual, "Player's balance did not decrease correctly when landing on Income Tax.");
        }


        [TestMethod]
        public void LandingOnIncomeTaxTest5()
        {
            Player p1 = new Player("Sarah");
            p1.balance = 1800;

            double expected = p1.balance;

            p1.position = 0;

            p1.move(6);

            double actual = p1.balance;

            Assert.AreEqual(expected, actual, "Player's balance decreased when passing over Income Tax.");
        }
    }
}
