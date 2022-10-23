using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Shared.TestCaseLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting;
using UITesting.Elements;

namespace TestingProject.ExtendedElements
{
    public class ListExtended : UITesting.Elements.List
    {
        public ListExtended(By SearchBy, string NameOfElement) : base(SearchBy, NameOfElement)
        {
        }

        public ListExtended(By SearchBy, By SearchListElementsBy, string NameOfElement) : base(SearchBy, SearchListElementsBy, NameOfElement)
        {

        }

        /// <summary>
        /// Moves to an element in list using Actions class.
        /// </summary>
        /// <param name="Text">Text of an element in list.</param>
        /// <exception cref="Exception"></exception>
        public void MoveToElementInList(string Text)
        {
            Actions Builder = new Actions(WebDriverSetup.WebDriver);

            List<IWebElement> Elements = ElementsInList();
            bool bFound = false;


            foreach (IWebElement Element in Elements)
            {
                if (Element.Text.Contains(Text))
                {
                    TCLogger.Log($"Moving to '{Text} element in list.'", GetElementName());
                    Builder.MoveToElement(Element).Build().Perform();
                    bFound = true;

                    break;
                }
            }

            if (!bFound)
                throw new Exception(String.Format("Element in the list not found"));
        }


        /// <summary>
        /// Returns a sublist of a list.
        /// </summary>
        /// <param name="SearchBy">Locator to search a sublist by.</param>
        /// <param name="SearchListElementsBy">Locator to searhc items in sublist by.</param>
        /// <param name="ElementName">Name of the sublist.</param>
        /// <returns>ListExtended</returns>
        public ListExtended GetSubList(By SearchBy, By SearchListElementsBy, string ElementName)
        {
            return new ListExtended(SearchBy, SearchListElementsBy, ElementName);
        }

        /// <summary>
        /// Verifies if the add to cart button for the given product is displayed and enabled.
        /// </summary>
        /// <param name="ProductName">Name of the product.</param>
        /// <exception cref="Exception"></exception>
        public void VerifyAddToCartButtonDisplayedAndEnabled(string ProductName)
        {

            List<IWebElement> Elements = ElementsInList();
            bool bFound = false;
            IWebElement ElementInList = null;

            foreach (IWebElement Element in Elements)
            {
                if (Element.Text.Contains(ProductName))
                {
                    bFound = true;
                    ElementInList = Element.FindElement(By.ClassName("product-box-add-to-cart-button"));
                    break;
                }
            }

            if (!bFound)
                throw new Exception(String.Format("Element in the list not found"));

            else
            {
                TCLogger.Log($"Verifying that the add to cart button for the given '{ProductName}' product is displayed and enabled.", GetElementName());
                Assert.IsTrue(ElementInList.Displayed);
                Assert.IsTrue(ElementInList.Enabled);
            }



        }


    }
}
