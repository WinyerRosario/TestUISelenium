using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestUISelenium.WebDriverExtensions
{
    public static class WebDriverExtensions
    {
        /// <summary>
        /// Enter the text in textboxes / Edit boxes
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="locator"></param>
        /// <param name="value"></param>
        public static void EnterText(this IWebDriver driver, By locator, string value) 
        {
            IWebElement ele = driver.FindElement(locator);
            if (ele.Displayed && ele.Enabled) {
            
                ele.Clear();
                ele.SendKeys(value);
            }
        }
        /// <summary>
        /// Click the button, radio button, Checkboxes
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="locator"></param>
        public static void Click(this IWebDriver driver, By locator) 
        {
            IWebElement ele = driver.FindElement(locator);
            if(ele.Displayed && ele.Enabled) 
            {
                ele.Click();
            }
        }

        public static bool IsElementDisplayed(this IWebDriver driver, By locator) 
        {
            IWebElement ele = driver.FindElement(locator);
            if(ele.Displayed) 
            {
                return true;
            }
            return true;
        }

        /// <summary>
        /// Get text of WebElement
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static string getText(this IWebDriver driver, By locator) {
        
            IWebElement ele = driver.FindElement(locator);
            var text = "";
            if(ele.Displayed) 
            {
                text = ele.Text;
            }
            return text;
        }

        /// <summary>
        /// Element Text displayed 
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool getTextWithValueDisplayed(this IWebDriver driver, string value) 
        {
            var text = "";
            IWebElement ele = driver.FindElement(By.XPath("//*[text()='" + value + "']"));
            if(ele.Displayed) 
            {
                return true;
            }
            return true;
        }

        public static void IsAlertPresent() 
        {

        }

        public static void SelectByVisibleTextFromDropDown() 
        {

        }

    }
}
