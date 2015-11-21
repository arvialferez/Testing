using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Events.Tests
{
    [TestClass]
    public class TaggingWebApiTest : Test
    {
        //[TestMethod]
        public void BrowserTest()
        {
            driverGC.Navigate().GoToUrl("http://www.google.com");
            driverGC.FindElement(By.Id("lst-ib")).SendKeys("Selenium");
            driverGC.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
            driverGC.Quit();
        }

        [TestMethod]
        public void WebApiPendingTest()
        {
            CreateAssignEIDEvent();

            // Verify the event in AnimalEvent table with a status of pending

            // Verify the event in AI proposed assign eid table

        }

        public string CreateAssignEIDEvent()
        {
            // Create the body to be used for the request
            string body = string.Empty;

            // Create an authentication token

            // Send the request

            return null;
        }

        public void Send()
        {
 
        }

    }

}
