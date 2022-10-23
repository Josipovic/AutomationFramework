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
    public class RadioButton :MainElement
    {
       
        public RadioButton(By SearchBy, string NameOfElement) : base(SearchBy, NameOfElement)
        {
        }


        /// <summary>
        /// Method verifies if the RadioButton is selected.
        /// </summary>
        /// <param name="Selected">If set to false, verifies that the button is not selected. It is true by default.</param>
        public void VerifySelected(bool Selected=true)
        {
            Element = GetElement();

            if (Selected)
            {
                TCLogger.Log("Verifying radio button is selected.", GetElementName());
                Assert.IsTrue(Element.Selected);
            }

            if (Selected)
            {
                TCLogger.Log("Verifying that radio button is not selected.", GetElementName());
                Assert.IsFalse(Element.Selected);
            }
        }
    }
}
