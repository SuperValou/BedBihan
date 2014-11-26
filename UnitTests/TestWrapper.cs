using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BedBihan;

namespace UnitTests

{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestWrapperTropFoo()
        {
            testWrapper tW = new testWrapper();
            int x = tW.go(21);

            Assert.AreEqual(42, x);
        }
    }
}
