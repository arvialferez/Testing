using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Tests
{
    [TestClass]
    public class TaggingWebApiTest : Test
    {
        [TestMethod]
        public void BrowserTest()
        {
            driverGC.Navigate().GoToUrl("http://www.google.com");
            driverGC.FindElement(By.Id("lst-ib")).SendKeys("Selenium");
            driverGC.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
            driverGC.Quit();
        }
    }
}
