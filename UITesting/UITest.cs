using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITesting
{
    public class UITest
    {
     
        public UITest(string TestCaseCode, string TestCaseName)
        {
            TestCaseData.TestCaseCode = TestCaseCode;
            TestCaseData.TestCaseName = TestCaseName;
        


            WebDriverSetup.DriverSetup();
        }

    }
}
