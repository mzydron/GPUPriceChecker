using GPUPriceChecker;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace UnitTests.WebScrapingTests
{
    [TestFixture]
    class WebScrapingTests
    {
        [Test]
        public static void PrepareWebRequest()
        {
            WebOperations webOps = new WebOperations();

            Assert.IsTrue(false);
            

        }

        [Test]
        public static void SuccesfullGetRecived()
        {
            WebOperations webOps = new WebOperations();
            HttpWebResponse wr = webOps.SendGetRequestAndReturnResponse();

            Assert.AreEqual(200, (int)wr.StatusCode);
            
        }

        [Test]
        public static void SaveWebPageToFile()
        {
            string filename = "";

            WebOperations webOps = new WebOperations();
            webOps.SaveWebPageToFile(filename);

            FileAssert.Exists(filename);

        }
    }
}
