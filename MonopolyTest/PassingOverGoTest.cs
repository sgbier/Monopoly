using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTest
{
    [TestClass]
    public class PassingOverGoTest
    {
        [TestMethod]
        public void PassingOverGoTest1()
        {
            Player p1 = new Player("Sarah");

            double expected = p1.balance + 200.0;

            p1.position = 31;

            p1.move(12);

            double actual = p1.balance;

            Assert.AreEqual(expected, actual, "Player did not receive $200 when passing Go.");
        }

        [TestMethod]
        public void PassingOverGoTest2()
        {
            Player p1 = new Player("Sarah");

            double expected = p1.balance;

            p1.position = 0;

            p1.move(9);

            double actual = p1.balance;

            Assert.AreEqual(expected, actual, "Player's balance changed when starting on Go, but not landing on or passing over Go.");
        }


        [TestMethod]
        public void PassingOverGoTest3()
        {
            Player p1 = new Player("Sarah");

            double expected = p1.balance + 400.0;

            p1.position = 31;

            p1.move(25);
            p1.move(25);

            double actual = p1.balance;

            Assert.AreEqual(expected, actual, "Player did not receive $400 when passing Go twice during a turn.");
        }

    }
}
