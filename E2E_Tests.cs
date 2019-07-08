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
            //browser.MaximiseWindow();
            browser.Visit("demosite/Login.html");

            if (browser.Title == "Execute Automation")
            {
                Console.WriteLine("It works!!!");
            }

            browser.FillIn("UserName").With("Roman");
            browser.FillIn("Password").With("12345");
            browser.ClickButton("Login");


            browser.Dispose();
           


            
        }

        [TearDown]
        public void TearDown()
        {
           
        }
    }
}