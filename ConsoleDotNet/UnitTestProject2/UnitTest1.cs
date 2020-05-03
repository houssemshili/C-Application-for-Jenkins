using System;
using ConsoleDotNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 instance = new Class1();
            Assert.IsTrue(instance.ReturnBool());
        }
    }
}
