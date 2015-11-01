using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Events.Tests
{
    [TestClass]
    public class Test
    {

        public static IWebDriver driverGC;

        [AssemblyInitialize]
        public static void Setup(TestContext testContext)
        {
            driverGC = new ChromeDriver(@"C:\Users\arvialferez\Documents\Github\Testing\Events\Events\lib\chromedriver_win32");
        }

        [TestMethod]
        public void TestChromeDriver()
        {
            driverGC.Navigate().GoToUrl("http://www.google.com");
            driverGC.FindElement(By.Id("lst-ib")).SendKeys("Selenium");
            driverGC.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
            //driverGC.Quit();
        }
    }
}
