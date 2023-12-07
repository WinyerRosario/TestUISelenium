using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using TestUISelenium.BasePage;
using TestUISelenium.Pages;

namespace TestUISelenium.Tests
{
    [TestClass]
    public class LoginTest  : BaseClass
    {
        HomePage homePage;
        LoginPage loginPage;
        [TestMethod]
        [TestCategory("Smoke")]
        public void VerifyLoginFunctionalityWithValidData()
        {
            string username = ConfigurationManager.AppSettings["Email"];
            string password = ConfigurationManager.AppSettings["Password"];
            homePage = new HomePage(driver);
            loginPage = new LoginPage(driver);
            homePage.ClickLoginLink();
            String title = homePage.getTitle();
            Assert.AreEqual(title, "Demo Web Shop. Login");
            loginPage.EnterEmailAddress(username);
            loginPage.EnterEmailAddress(password);
            loginPage.ClickLoginBUtton();
        }
    }
}
