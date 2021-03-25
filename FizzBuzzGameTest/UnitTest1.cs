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

            String FizzStr = FizzBuzz.BobRepond(nb);

            Assert.AreEqual("Fizz", FizzStr);
        }

        [TestMethod]
        public void DoitDonnerFizzSiNombre9()
        {
            int nb = 9;
            String actual = FizzBuzz.BobRepond(nb);

            Assert.AreEqual("Fizz", actual);
        }
    }
}
