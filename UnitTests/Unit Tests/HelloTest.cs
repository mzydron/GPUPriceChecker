using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{

    [TestFixture]
    public class HelloTest
    {

        [Test]
        public void Hello()
        {
            string Hello = "Hello World!";
            Assert.AreEqual(Hello, GPUPriceChecker.Program.Greet());
        }



    }



}
