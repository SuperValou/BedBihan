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
            int testFortyTwo = WrapperGate.access.computeFoo(21); 

            Assert.AreEqual(42, testFortyTwo);
        }
    }
}
