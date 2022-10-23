using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Shared.TestCaseLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITesting.Elements
{
    public class DropDown : MainElement
    {
        public DropDown(By SearchBy, string NameOfElement) : base(SearchBy, NameOfElement)
        {
        }

        /// <summary>
        /// Verifies if the option is selected in the dropdown.
        /// </summary>
        /// <param name="Option">Text of the option.</param>
        /// <param name="Selected">If set to false, verifies that the option is not selected, it is true by default.</param>
        public void VerifyOptionSelected(string Option, bool Selected = true)
        {
            Element = GetElement();
            SelectElement SelectElement = new SelectElement(Element);

            if (Selected)
            {
                TCLogger.Log($"Verifying if the '{Option}' option is selected in the dropdown.", GetElementName());
                Assert.That(SelectElement.SelectedOption.Text.Equals(Option));
            }

            else
            {
                TCLogger.Log($"Verifying that the '{Option}' option is not selected in the dropdown.", GetElementName());
                Assert.That(!SelectElement.SelectedOption.Text.Equals(Option));
            }


        }
        /// <summary>
        /// Verifies if the selcted option contains given text.
        /// </summary>
        /// <param name="Option">Text of the option.</param>
        /// <param name="Contains">If set to false, verifies that the option does not contain given text, it is true by default.</param>
        public void VerifyOptionSelectedContains(string Option, bool Contains = true)
        {
            Element = GetElement();
            SelectElement SelectElement = new SelectElement(Element);

            if (Contains)
            {
                TCLogger.Log($"Verifying that the selected option text contains '{Option}' text", GetElementName());
                Assert.That(SelectElement.SelectedOption.Text.Contains(Option));
            }
          
            else
            {
                TCLogger.Log($"Verifying that the selected option text does not contain '{Option}' text", GetElementName());
                Assert.That(!SelectElement.SelectedOption.Text.Contains(Option));
            }
              

        }

        /// <summary>
        /// Selects option in dropdown by text.
        /// </summary>
        /// <param name="Option">Text of the option.</param>
        public void SelectOptionByText(string Option)
        {
            Element = GetElement();
            SelectElement SelectElement = new SelectElement(Element);

            TCLogger.Log($"Selecting '{Option}' option", GetElementName());
            SelectElement.SelectByText(Option);
        }
    }
}
