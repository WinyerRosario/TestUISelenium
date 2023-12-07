using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Cryptography.X509Certificates;
using TestUISelenium.Reports;

namespace TestUISelenium
{
    [TestClass]
    public class SampleTest
    {
        String email = "Carlospaul394920@gmail.com";
        IWebDriver driver;

        [TestInitialize]
        public void Init() 
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.Manage().Window.Maximize();
        }
        [TestCategory("SampleTest")]
        [TestMethod]
        public void TestMethod1()
        {
            try
            {

                String title = driver.Title;
                Assert.AreEqual(title, "Demo Web Shop");

                driver.FindElement(By.ClassName("ico-register")).Click();

                String registertitle = driver.Title;
                Assert.AreEqual(registertitle, "Demo Web Shop. Register");

                driver.FindElement(By.Id("gender-male")).Click();

                driver.FindElement(By.Id("FirstName")).SendKeys("Carlos");

                driver.FindElement(By.Id("LastName")).SendKeys("Paul");

                driver.FindElement(By.Id("Email")).SendKeys(email);

                driver.FindElement(By.Name("Password")).SendKeys("Password");

                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Password");

                driver.FindElement(By.Id("register-button")).Click();

                String message = driver.FindElement(By.ClassName("result")).Text;
                Assert.AreEqual(message, "Your registration completed");

                IWebElement emailAccount = driver.FindElement(By.XPath("//*[text()='" + email + "']"));
                Assert.IsTrue(emailAccount.Displayed);

                driver.FindElement(By.ClassName("ico-logout")).Click();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
            [TestCleanup]
            public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
