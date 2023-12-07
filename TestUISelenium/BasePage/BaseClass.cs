using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using NUnit.Framework;
using TestContext = NUnit.Framework.TestContext;
using NUnit.Framework.Interfaces;
using TestUISelenium.Handler;

namespace TestUISelenium.BasePage
{
    public class BaseClass
    {
        public static IWebDriver driver;
        [TestInitialize]
        public void Init()
        {
            string siteurl = ConfigurationManager.AppSettings["Url"];

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(siteurl);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void AfterBaseTesr() 
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            if (status == TestStatus.Failed)
                ScreenShotHandler.TakeScreenshot(driver);

            if (driver != null) 
            {
                driver.Close();
            }

        }

        [TestCleanup]
        public void Cleanup() 
        {
            driver.Close();
        }
    }
}
