﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITesting.Elements
{
    public class Button : MainElement
    {
        public Button(By SearchBy, string NameOfElement) : base(SearchBy, NameOfElement)
        {
        }
    }
}
