using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzz
{
    [TestClass]
    public class UnitTest
    {
        private Prog Program = new Prog();
        public Prog program
        {
            get { return Program; }
            set { Program = value; }
        }


        [TestMethod]
        public void TestMethod1()
        {
            int expect = 1;
            int actual = Program.FizzBuzz(1);
            Assert.AreEqual<int>(expect, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int expect = 2;
            int actual = Program.FizzBuzz(2);
            Assert.AreEqual<int>(expect, actual);
        }
    }
}
