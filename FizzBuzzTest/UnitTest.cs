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
            string actual = FizzBuzz(1);
            Assert.AreEqual<string>("1", actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string actual = FizzBuzz(3);
            Assert.AreEqual<string>("Fizz", actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string actual = FizzBuzz(5);
            Assert.AreEqual<string>("Buzz", actual);
        }
    }
}
