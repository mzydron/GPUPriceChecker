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

            Assert.IsAssignableFrom<HttpWebRequest>(webOps.CreateWebRequest());
            
        }

        [Test]
        public static void PrepareCustomWebRequest()
        {
            WebOperations webOps = new WebOperations();
            HttpWebRequest request = webOps.CreateWebRequest();
            HttpWebRequest customRequest = webOps.CreateWebRequest("http://onet.pl");

            Assert.IsFalse(request.Address == customRequest.Address);
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
            
            WebOperations webOps = new WebOperations();
            webOps.SaveWebPageToFile();

            
            FileAssert.Exists(webOps.savedFilePath);
        }
    }
}
