using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhichMsTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WhichMsTest.Tests
{
    [TestClass()]
    public class X1Tests
    {
        [TestMethod()]
        public void Method1Test()
        {
            var x1 = new X1();
            Assert.ThrowsException<FileNotFoundException>(() => x1.Method1());
            Assert.Fail();
        }
    }
}