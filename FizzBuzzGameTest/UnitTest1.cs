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
    }
}
