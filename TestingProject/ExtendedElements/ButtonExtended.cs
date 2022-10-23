using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Elements;

namespace TestingProject.ExtendedElements
{
    public class ButtonExtended : Button
    {
        public ButtonExtended(By SearchBy, string NameOfElement) : base(SearchBy, NameOfElement)
        {
        }
    }
}
