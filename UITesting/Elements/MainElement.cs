using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using UITesting.Helpers;
using Shared.TestCaseLogger;

namespace UITesting.Elements
{
    public class MainElement
    {

        private By _SearchBy { get; set; }
        public IWebElement Element { get; set; }
        public string ElementName { get; set; }

        public IWebElement GetElement()
        {
            return WaitHelpers.GetElement(_SearchBy);
        }
        public string GetElementName()
        {
            return new System.Diagnostics.StackTrace().GetFrame(1).GetMethod().DeclaringType.FullName + " " + ElementName;
        }

        public MainElement(By SearchBy, string NameOfElement)
        {
            _SearchBy = SearchBy;
            ElementName = NameOfElement;
        }

        /// <summary>
        /// Method verifies if the web element is displayed.
        /// </summary>
        /// <param name="Displayed">If set to false, verifies that the element is not displayed. It is true by default</param>
        public void VerifyDisplayed(bool Displayed = true)
        {
            Element = GetElement();

            if (Displayed)
            {
                TCLogger.Log("Verifying element displayed.", GetElementName()); ;
                Assert.IsTrue(Element.Displayed);

            }

            else
            {
                TCLogger.Log("Verifying element not displayed.", GetElementName());
                Assert.IsFalse(Element.Displayed);
            }

        }

        /// <summary>
        /// Verifies if the element exists.
        /// </summary>
        /// <param name="bExists">If set to false verifies that the element does not exists. It is true by default.</param>
        public void VerifyExists(bool bExists = true)
        {

            try
            {
                Element = GetElement();
            }
            catch (Exception)
            {

                Element = null;
            }

            if (bExists)
            {
                TCLogger.Log("Verifying that the element exists.", GetElementName()); ;
                Assert.IsTrue(Element != null);

            }

            else
            {
                TCLogger.Log("Verifying that the element does not exist.", GetElementName());
                Assert.IsFalse(Element != null);
            }
        }

        /// <summary>
        /// Method verifies if the web element is enabled.
        /// </summary>
        /// <param name="Enabled">If set to false, verifies that the element is disabled. It is true by default</param>
        public void VerifyEnabled(bool Enabled = true)
        {
            Element = GetElement();

            if (Enabled)
            {
                TCLogger.Log("Verifying element enabled.", GetElementName());
                Assert.IsTrue(Element.Enabled);
            }


            else
            {
                TCLogger.Log("Verifying element not enabled.", GetElementName());
                Assert.IsFalse(Element.Enabled);
            }

        }

        /// <summary>
        /// Clicks on the given element.
        /// </summary>
        public void Click()
        {
            TCLogger.Log("Clicked on an element.", GetElementName());
            GetElement().Click();
        }



        /// <summary>
        /// Sends text to the given element.
        /// </summary>
        /// <param name="Text">Text to be sent.</param>
        public void SetText(string Text)
        {
            Element = GetElement();

            TCLogger.Log($"Setting text to '{Text}' text.", GetElementName());
            Element.SendKeys(Keys.Control + "a");
            Element.SendKeys(Text);
        }

        /// <summary>
        /// Retreives text from the element.
        /// </summary>
        /// <returns>String</returns>
        public string GetText()
        {
            TCLogger.Log($"Retreiving text from an element.", GetElementName());
            return GetElement().Text;
        }

        /// <summary>
        /// Method verifies if the element has given text.
        /// </summary>
        /// <param name="Text">Text to be verified.</param>
        /// <param name="Contains">If set to false, verifies that the element does not have the given text. It is true by default</param>
        public void VerifyTextContains(string Text, bool Contains = true)
        {
            Element = GetElement();

            if (Contains)
            {
                TCLogger.Log($"Verifying if text of an element is equal to '{Text}' text.", GetElementName());

                Assert.IsTrue(WaitHelpers.VerifyTextContains(Element, Text,10));

            }

            else
            {
                TCLogger.Log($"Verifying that text of an element is not equal to '{Text}' text.", GetElementName());
                Assert.False(WaitHelpers.VerifyTextContains(Element, Text,10));
            }

        }

        /// <summary>
        /// Moves to given element using Actions class.
        /// </summary>
        public void MoveToElement()
        {
            Element = GetElement();
            Actions Builder = new Actions(WebDriverSetup.WebDriver);

            TCLogger.Log("Moving to element.", GetElementName());
            Builder.MoveToElement(Element).Build().Perform();
        }

    }
}
