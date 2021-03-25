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
        public void DoitDonnerBuzzSiNombre25()
        {
            int nb = 25;

            String actual = FizzBuzz.BobRepond(nb);

            Assert.AreEqual("Buzz", actual);
        }
    }
}
