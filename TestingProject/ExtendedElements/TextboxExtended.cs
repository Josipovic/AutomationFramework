using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Elements;

namespace TestingProject.ExtendedElements
{
    public class TextboxExtended : TextBox
    {
        public TextboxExtended(By SearchBy, string NameOfElement) : base(SearchBy, NameOfElement)
        {
        }
    }
}
