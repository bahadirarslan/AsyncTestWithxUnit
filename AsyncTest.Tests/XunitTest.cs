using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AsyncTest.Tests {
    public class XunitTest {
        [Fact]
        public async void XunitTestMethod_Async() {
            Program p = new Program();
            string result = await p.AsyncTestMethod();
            Assert.Equal("Ok", result);
        }
            [Fact]
        public  void XunitTestMethod_Normal() {
            Program p = new Program();
            string result =  p.NormalTestMethod();
            Assert.Equal("Ok", result);
        }
    }
}
