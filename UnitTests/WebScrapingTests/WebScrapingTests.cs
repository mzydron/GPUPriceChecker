﻿using GPUPriceChecker;
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
        public static void SuccesfullGetRecived()
        {
            WebOperations webOps = new WebOperations();
            HttpWebResponse wr = webOps.SendGetRequest();

            Assert.AreEqual(200, (int)wr.StatusCode);


        }
    }
}