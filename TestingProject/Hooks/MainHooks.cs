using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TestingProject.Hooks
{
    [Binding]
    public class MainHooks
    {
        string TestCaseName;
        string TestCaseCode;
        public static string[] ScenarioTags;

        [BeforeScenario("UI", Order = 0)]
        public void BeforeScenario(ScenarioContext ScenarioContext)
        {
            TestCaseName = ScenarioContext.ScenarioInfo.Title;
            TestCaseCode = ScenarioContext.ScenarioInfo.Tags.FirstOrDefault(x => x.Contains("TestCaseCode")).Replace("TestCaseCode:", "");

            UITesting.UITest UITest = new UITesting.UITest(TestCaseCode, TestCaseName);
            ScenarioTags = ScenarioContext.ScenarioInfo.Tags;
        }

        [AfterScenario("UI", Order = 0)]
        public void AfterScenario(ScenarioContext ScenarioContext)
        {
            UITesting.WebDriverSetup.DriverTearDown();
        }
    }
}
