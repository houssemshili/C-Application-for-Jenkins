using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1, b = 1;
            Assert.IsTrue(a == b);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int a = 1, b = 2;
            Assert.IsTrue(a == b);
        }
    }
}
