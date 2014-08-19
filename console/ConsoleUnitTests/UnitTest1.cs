using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using console;

namespace ConsoleUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p = MyClassToTest.Return5();
            Assert.AreEqual(p, 5);
        }

        [TestMethod]
        public void BadUnitTest()
        {
            var p = MyClassToTest.Return5();
            Assert.AreEqual(p, 6,"This test will fail");
        }
    }
}
