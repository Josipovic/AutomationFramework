using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITesting.Helpers
{
    public class WaitHelpers
    {
        public static bool VerifyUrlDisplayed(string Url, int WaitTime = 5)
        {
            WebDriverWait Wait = new WebDriverWait(WebDriverSetup.WebDriver, TimeSpan.FromSeconds(WaitTime));
            bool Displayed = false;

            try
            {
                Displayed = Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(Url));
            }
            catch (Exception)
            {


            }

            return Displayed;
        }

        public static bool VerifyUrlContains(string Url, int WaitTime = 5)
        {
            WebDriverWait Wait = new WebDriverWait(WebDriverSetup.WebDriver, TimeSpan.FromSeconds(WaitTime));

            bool Contains = false;

            try
            {
                Contains = Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains(Url));
            }
            catch (Exception)
            {


            }

            return Contains;
        }

        public static bool VerifyTextContains(IWebElement Element, string Text, int WaitTime = 5)
        {
            WebDriverWait Wait = new WebDriverWait(WebDriverSetup.WebDriver, TimeSpan.FromSeconds(WaitTime));

            bool Contains = false;
            try
            {
                Contains = Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(Element, Text));
            }
            catch (Exception)
            {


            }

            return Contains;
        }

        public static IWebElement GetElement(By SearchBy, int WaitTime = 10)
        {
            WebDriverWait Wait = new WebDriverWait(WebDriverSetup.WebDriver, TimeSpan.FromSeconds(WaitTime));

            IWebElement Element = null;
           
            try
            {
                Element = Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(SearchBy));
            }
            catch (Exception)
            {


            }

            return Element;
        }

        public static void Wait(int WaitTime)
        {
            Thread.Sleep(TimeSpan.FromSeconds(WaitTime));
        }

    }
}
