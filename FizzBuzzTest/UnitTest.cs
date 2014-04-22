using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzz
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var test = new Prog();
            int expect = 1;
            int actual = test.FizzBuzz(1);
            Assert.AreEqual<int>(expect, actual);
        }
    }
}
