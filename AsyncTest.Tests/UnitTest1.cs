using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AsyncTest.Tests {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public async void AsyncTestMethod_Test() {
            Program p = new Program();
            string result = await p.AsyncTestMethod();
            Assert.AreEqual("Ok", result);
        }
    }
}
