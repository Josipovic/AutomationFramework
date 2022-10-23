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
    public class TextBox : MainElement
    {
    

        public TextBox(By SearchBy, string NameOfElement) : base(SearchBy, NameOfElement)
        {
        }

        /// <summary>
        /// Verifies if the textbox is empty.
        /// </summary>
        /// <param name="Empty">If set to false, verifies that the textbox is not empty. It is true by default.</param>
        public void VerifyEmpty(bool Empty = true)
        {
            Element = GetElement();
          
            if (Empty)
            {
                TCLogger.Log("Verifying textbox is empty.", GetElementName());
                Assert.IsTrue(Element.GetAttribute("value") == "");
            }

            if (!Empty)
            {
                TCLogger.Log("Verifying taht textbox is not empty.", GetElementName());
                Assert.IsFalse(Element.GetAttribute("value") != "");
            }
        }

        /// <summary>
        /// Method verifies if the element has given text.
        /// </summary>
        /// <param name="Text">Text to be verified.</param>
        /// <param name="Equals">If set to false, verifies that the element does not have the given text. It is true by default</param>
        public void VerifyText(string Text, bool Equals = true)
        {
            Element = GetElement();

            if (Equals)
            {
                TCLogger.Log($"Verifying if text of a textbox is equal to '{Text}' text.", GetElementName());

                Assert.IsTrue(Element.GetAttribute("value").Equals(Text));

            }

            else
            {
                TCLogger.Log($"Verifying that the text of a textbox is not equal to '{Text}' text.", GetElementName());
                Assert.False(Element.GetAttribute("value").Equals(Text));
            }

        }

        /// <summary>
        /// Method verifies if the element contains given text.
        /// </summary>
        /// <param name="Text">Text to be verified.</param>
        /// <param name="Contains">If set to false, verifies that the element does not contain the given text. It is true by default</param>
        public void VerifyTextContains(string Text, bool Contains = true)
        {
            Element = GetElement();

            if (Contains)
            {
                TCLogger.Log($"Verifying if text of an element contains '{Text}' text.", GetElementName());
                Assert.IsTrue(Element.GetAttribute("value").Contains(Text));

            }

            else
            {
                TCLogger.Log($"Verifying that text of an element does not contain '{Text}' text.", GetElementName());
                Assert.False(Element.GetAttribute("value").Contains(Text));
            }

        }
    }
}
