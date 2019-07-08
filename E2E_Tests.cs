using Coypu;
using Coypu.Drivers;
using Coypu.Drivers.Selenium;
using NUnit.Framework;
using System;

namespace CoypuTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            var sessionConfiguration = new SessionConfiguration()
            {
                AppHost = "executeautomation.com",
                Driver = typeof(SeleniumWebDriver),
                Browser = Browser.Chrome,
                //Port = 80,
                //SSL = true
            };

            var browser = new BrowserSession(sessionConfiguration);
            browser.Visit("demosite/Login.html");
            browser.Dispose();

        }

        [TearDown]
        public void TearDown()
        {
           
        }
    }
}