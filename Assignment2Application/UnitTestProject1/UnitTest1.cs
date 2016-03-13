using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment2Application;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        FibonacciGenerator _gen = new FibonacciGenerator();

        [TestMethod]
        public void FibonacciGeneratorBasic()
        {
            Assert.Equals(_gen.Get(0), 0);
            Assert.Equals(_gen.Get(1), 1);
            Assert.Equals(_gen.Get(2), 1);
            Assert.Equals(_gen.Get(3), 2);
            Assert.Equals(_gen.Get(4), 3);
            Assert.Equals(_gen.Get(5), 5);
        }

        [TestMethod]
        public void FibonacciGenerator9()
        {
            Assert.Equals(_gen.Get(9), 34);
        }

        [TestMethod]
        public void FibonacciGeneratorBig()
        {
            Assert.AreNotSame(_gen.Get(12345678), 0);
        }
    }
}
