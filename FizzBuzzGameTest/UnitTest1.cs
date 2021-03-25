using System;
using FizzBuzzGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzGameTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void DoitDonnerFizzSiNombre24()
        {
            int nb = 24;

            String actual = FizzBuzz.BobRepond(nb);

            Assert.AreEqual("Fizz", actual);
        }

        [TestMethod]
        public void DoitDonnerBuzzSiNombre35()
        {
            int nb = 35;

            String actual = FizzBuzz.BobRepond(nb);

            Assert.AreEqual("Buzz", actual);
        }

        [TestMethod]
        public void DoitDonnerFizzBuzzSiNombre15()
        {
            int nb = 15;

            String actual = FizzBuzz.BobRepond(nb);

            Assert.AreEqual("FizzBuzz", actual);
        }


    }
}
