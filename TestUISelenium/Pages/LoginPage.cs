using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUISelenium.WebDriverExtensions;

namespace TestUISelenium.Pages
{
    public class LoginPage
    {
        //Instance for Webdriver
        public static IWebDriver driver;

        //constructor
        public LoginPage(IWebDriver driver) {
            LoginPage.driver = driver;
        }

        public string getTitle() 
        {
            return driver.Title;
        }
        public static readonly By emailtxt = By.Id("Email");
        public static readonly By passwordtxt = By.Id("Password");
        public static readonly By loginbtn = By.CssSelector("input.button-1.login-button");

        public void EnterEmailAddress(String email) 
        {
            driver.EnterText(emailtxt, email);
        }

        public void EnterPassword(String password)
        {
            driver.EnterText(passwordtxt, password);
        }

        public void ClickLoginBUtton()
        {
            driver.Click(loginbtn);
        }
    }
}
