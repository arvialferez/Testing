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

        public void Setup()
        {
            driverGC = new ChromeDriver(@"F:\Documents\GitHubVisualStudio\Testing\Events\packages\WebDriver.ChromeDriver.win32.2.20.0.0\content");
        }

        [AssemblyInitialize]
        public static void Setup(TestContext testContext)
        {
            driverGC = new ChromeDriver(@"F:\Documents\GitHubVisualStudio\Testing\Events\packages\WebDriver.ChromeDriver.win32.2.20.0.0\content");
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
