using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTest {
    public class Program {
        static void Main(string[] args) {
        }

        public async Task<string> AsyncTestMethod() {
            throw new Exception("Test");
        }
        public string NormalTestMethod() {
            throw new Exception("Test");
        }
    }
}
