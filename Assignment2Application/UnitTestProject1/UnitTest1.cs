using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment2Application;

namespace UnitTestProject1 {

	[TestClass]
    public class UnitTest1
    {
        FibonacciGenerator _gen = new FibonacciGenerator();

        [TestMethod]
        public void FibonacciGeneratorBasic()
        {
            Assert.AreEqual(_gen.Get(1), 1);
            Assert.AreEqual(_gen.Get(2), 1);
            Assert.AreEqual(_gen.Get(3), 2);
            Assert.AreEqual(_gen.Get(4), 3);
            Assert.AreEqual(_gen.Get(5), 5);
        }

        [TestMethod]
        public void FibonacciGenerator9()
        {
            Assert.AreEqual(_gen.Get(1), 1);
        }

        [TestMethod]
        public void FibonacciGeneratorBig()
        {
            Assert.AreNotSame(_gen.Get(123456789), 0);
        }
    }
}
