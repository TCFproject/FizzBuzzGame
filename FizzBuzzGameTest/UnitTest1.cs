using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzGameTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void AliceDonneUnNombreMultipleDe3()
        {
            int nb = 24;

            String FizzStr = FizzBuzz.BobRepond(nb);

            Assert.AreEqual("Fizz", FizzStr);
        }
    }
}
