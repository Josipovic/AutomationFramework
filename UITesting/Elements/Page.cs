using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using Shared.TestCaseLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITesting.Elements
{
    public class Page
    {
        public static string MainPage { get; set; }
        public string _Url { get; set; }

        private string ElementName { get; set; }
        public Page(string Url, string NameOfThePage)
        {
            _Url = Url;
            ElementName = NameOfThePage;
        }
        public string GetElementName()
        {
            return new System.Diagnostics.StackTrace().GetFrame(1).GetMethod().DeclaringType.FullName + " " + ElementName;
        }


        /// <summary>
        /// Method navigates to the given url
        /// </summary>
        public void Navigate()
        {
            string Url = Path.Combine(MainPage, _Url);

            TCLogger.Log($"Navigating to {Url}", GetElementName());
            WebDriverSetup.WebDriver.Navigate().GoToUrl(Url);

        }

        /// <summary>
        /// Method verifies if the given url is displayed.
        /// </summary>
        public void VerifyDisplayed()
        {
            string Url = Path.Combine(MainPage, _Url);

            TCLogger.Log($"'{Url}' url equals to '{WebDriverSetup.WebDriver.Url}'", GetElementName());
            Assert.IsTrue(Helpers.WaitHelpers.VerifyUrlDisplayed(Url, 10));

        }

        /// <summary>
        /// Method verifies if the current url displayed contains the given url chunk.
        /// </summary>
        public void VerifyContains()
        {
            TCLogger.Log($"''{WebDriverSetup.WebDriver.Url}' contains '{_Url}'", GetElementName());
            Assert.IsTrue(Helpers.WaitHelpers.VerifyUrlContains(_Url, 10));

        }


    }
}