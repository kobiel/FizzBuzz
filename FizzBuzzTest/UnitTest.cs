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
            string actual = Program.FizzBuzz(1);
            Assert.AreEqual<string>("1", actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string actual = Program.FizzBuzz(3);
            Assert.AreEqual<string>("Fizz", actual);
        }
    }
}
