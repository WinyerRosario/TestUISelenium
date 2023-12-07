using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TestUISelenium.WebDriverExtensions;

namespace TestUISelenium.Pages
{
    public class HomePage
    {
        public static IWebDriver driver;
        public HomePage(IWebDriver driver) { 
            HomePage.driver = driver;
        }

        public String getTitle() 
        {
            return driver.Title;
        }


        public static readonly By registerlink = By.ClassName("ico-register");
        public static readonly By loginlink = By.ClassName("ico-login");

        public void ClickRegisterLink() 
        {
            driver.Click(registerlink);
        }

        public void ClickLoginLink() 
        {
            driver.Click(loginlink);
        }
    }
}
