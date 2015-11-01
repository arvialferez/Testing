using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Events
{
    [TestClass]
    public class UnitTest1
    {

        static IWebDriver driverGC;

        [AssemblyInitialize]
        public static void Setup(TestContext testContext)
        {
            driverGC = new ChromeDriver(@"C:\Users\arvialferez\Documents\Visual Studio 2015\Projects\Events\Events\lib\chromedriver_win32");
        }

        [TestMethod]
        public void TestChromeDriver()
        {
            driverGC.Navigate().GoToUrl("http://www.google.com");
            driverGC.FindElement(By.Id("lst-ib")).SendKeys("Selenium");
            driverGC.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
        }
    }
}
