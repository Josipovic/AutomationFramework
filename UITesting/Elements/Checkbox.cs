using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.TestCaseLogger;

namespace UITesting.Elements
{
    public class Checkbox : MainElement
    {
        public Checkbox(By SearchBy, string NameOfElement) : base(SearchBy, NameOfElement)
        {
        }

        /// <summary>
        /// Verifies if the checkbox is checked.
        /// </summary>
        /// <param name="bChecked">If set tp false verifies that checkbox is not checked. It is false by defautl.</param>
        public void VerifyChecked(bool Checked = true)
        {
            Element = GetElement();
          
            if (Checked)
            {
                TCLogger.Log("Verifying if the checkbox is selected.", GetElementName());
                Assert.IsTrue(Element.Selected);
            }

            else
            {
                TCLogger.Log("Verifying that the checbox is not selected.", GetElementName());
                Assert.IsFalse(Element.Selected);
            }
        }
    }
}
