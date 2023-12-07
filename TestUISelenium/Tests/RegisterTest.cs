using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestUISelenium.BasePage;
using TestUISelenium.Pages;

namespace TestUISelenium.Tests
{
    [TestClass]
    public class RegisterTest  : BaseClass
    {
        String email = "jmartinn7523001@gmail.com";
        public HomePage homePage;
        public RegisterPage registerPage;
        [TestCategory("Smoke")]
        [TestMethod]
        public void VerifyRegisterFucntionalityWithValidata()
        {
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
            Assert.AreEqual(homePage.getTitle(), "Demo Web Shop");
            homePage.ClickRegisterLink();
            Assert.AreEqual(registerPage.getTitle(), "Demo Web Shop. Register");
            registerPage.SelectMaleRadio();
            registerPage.EnterFirstName("Juan");
            registerPage.EnterLastName("Martin");
            registerPage.EnterEmail(email);
            registerPage.EnterPassword("password");
            registerPage.EnterConfirmPassword("password");
            registerPage.ClickRegisterbtn();
            String result = registerPage.GetSuccessfullMesasge();
            Assert.AreEqual(result, "Your registration completed");
            bool isTrue = registerPage.IsEmailAccountDisplayed(email);
            Assert.IsTrue(isTrue);
            registerPage.clickLogout();

        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void VerifyAppLogoDisplayed() 
        {

        }
    }
}
