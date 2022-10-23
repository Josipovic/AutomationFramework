using NUnit.Framework;
using OpenQA.Selenium;
using Shared.TestCaseLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITesting.Elements
{
    public class List : MainElement
    {
        private By _SearchListElementsBy { get; set; }


        public List(By SearchBy, string NameOfElement) : base(SearchBy, NameOfElement)
        {
        }

        public List(By SearchBy, By SearchListElementsBy, string NameOfElement) : base(SearchBy, NameOfElement)
        {
            _SearchListElementsBy = SearchListElementsBy;
        }


        /// <summary>
        /// Gets all the elements in the list.
        /// </summary>
        /// <returns>List of IWebElements</returns>
        public List<IWebElement> ElementsInList()
        {
            Element = GetElement();

            return Element.FindElements(_SearchListElementsBy).ToList();

        }

        /// <summary>
        /// Verifies if the element in the list is displayed.
        /// </summary>
        /// <param name="Text">Text of the element.</param>
        /// <exception cref="Exception"></exception>
        public void VerifyElementInListDisplayed(string Text)
        {
            List<IWebElement> Elements = ElementsInList();
            bool bFound = false;
            IWebElement ElementInList = null;

            foreach (IWebElement Element in Elements)
            {
                if (Element.Text.Contains(Text))
                {
                    bFound = true;
                    ElementInList = Element;
                    break;
                }
            }

            if (!bFound)
                throw new Exception(String.Format("Element in the list not found"));

            else
            {
                TCLogger.Log($"Verifying if the '{Text}' element in the list is displayed.", GetElementName());
                Assert.IsTrue(ElementInList.Displayed);
            }

        }

        /// <summary>
        /// Verifies if the element in the list is enabled.
        /// </summary>
        /// <param name="Text">Text of the element.</param>
        /// <exception cref="Exception"></exception>
        public void VerifyElementInListEnabled(string Text)
        {
            List<IWebElement> Elements = ElementsInList();
            bool bFound = false;
            IWebElement ElementInList = null;

            foreach (IWebElement Element in Elements)
            {
                if (Element.Text.Contains(Text))
                {
                    bFound = true;
                    ElementInList = Element;
                    break;
                }
            }

            if (!bFound)
                throw new Exception(String.Format("Element in the list not found"));

            else
            {
                TCLogger.Log($"Verifying if the '{Text}' element in the list is enabled.", GetElementName());
                Assert.IsTrue(ElementInList.Enabled);
            }

        }

        /// <summary>
        /// Clicks on the element in the list.
        /// </summary>
        /// <param name="Text">Text of the element</param>
        /// <exception cref="Exception"></exception>
        public void ClickOnElementInList(string Text)
        {
            List<IWebElement> Elements = ElementsInList();
            bool bFound = false;


            foreach (IWebElement Element in Elements)
            {
                if (Element.Text.Contains(Text))
                {
                    bFound = true;
                    TCLogger.Log($"Clicking on the '{Text}' element in the list.", GetElementName());
                    Element.Click();
                    break;
                }
            }

            if (!bFound)
                throw new Exception(String.Format("Element in the list not found"));

        }

        /// <summary>
        /// Verifies if the list is empty.
        /// </summary>
        /// <param name="Empty">If set to false verifies that the list is not empty. It is true by default</param>
        public void VerifyEmpty(bool Empty = true)
        {
            List<IWebElement> Elements = ElementsInList();
            int ElementsCount = Elements.Count;

            if (!Empty)
            {
                TCLogger.Log($"Verifying that the list is not empty.", GetElementName());
                Assert.IsTrue(Elements.Count > 0);
            }

            else
            {
                TCLogger.Log($"Verifying that the list is empty.", GetElementName());
                Assert.False(Elements.Count > 0);
            }

        }
    }
}
