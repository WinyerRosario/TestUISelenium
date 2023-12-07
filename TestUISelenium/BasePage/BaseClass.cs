using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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


        [TestCleanup]
        public void Cleanup() 
        {
            driver.Close();
        }
    }
}
