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
            Assert.AreEqual(_gen.Get(0), 1);
            Assert.AreEqual(_gen.Get(1), 1);
            Assert.AreEqual(_gen.Get(2), 2);
            Assert.AreEqual(_gen.Get(3), 3);
            Assert.AreEqual(_gen.Get(4), 5);
            Assert.AreEqual(_gen.Get(5), 8);
        }

        [TestMethod]
        public void FibonacciGenerator9()
        {
            Assert.AreEqual(_gen.Get(9), 55);
        }

        [TestMethod]
        public void FibonacciGeneratorBig()
        {
            Assert.AreNotSame(_gen.Get(12345678), 0);
        }
    }
}
