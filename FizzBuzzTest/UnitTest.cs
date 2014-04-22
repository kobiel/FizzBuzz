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

        private string FizzBuzz(int num)
        {
            return Program.FizzBuzz(num);
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual<string>("1", FizzBuzz(1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual<string>("Fizz", FizzBuzz(3));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual<string>("Buzz", FizzBuzz(5));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual<string>("FizzBuzz", FizzBuzz(15));
        }
    }
}
