# AutomationFramework

## Overview


## IDE Setup :
1. Download and install Visual Studio IDE. Link : https://visualstudio.microsoft.com/vs/
2. Download and install .NET Core 6 SDK. Link : https://dotnet.microsoft.com/en-us/download/dotnet/6.0
3. After installing Visual studio IDE and .NET Core 6, you will need to add Specflow plugin into your Visual studio IDE.
Plugin can be added by clicking on Extensions -> Manage Extensions. Search for specflow and click install. You will need to reopen Visual studio IDE so the installation of the plugin can be finished.

## Configure run settings :
1. Solution wide runsettings file can be configured by clicking on Test -> Configure Run Settings -> Select Solution Wide runsettings file. Select the test.runsettings file which can be found in the TestingProject folder.

Runsettings file overview :

```
<RunSettings>
  <TestRunParameters>
    <Parameter name="AutomationLogPath" value="C:\AutomationLogs" />
    <Parameter name="Browser" value="Chrome" />
    <Parameter name="MaximizeWindow" value="true" />
    <Parameter name="DriverVersion" value="Latest" />
  </TestRunParameters>
</RunSettings>
```
Runsetting file contains mandatory settings :
1. AutomationLogPath : path where you wish to save the test case logs (logs will be saved as a txt file)
2. Browser : name of the browser on which the testing will be performed (Can be Chrome, Firefox and Edge)
3. MaximizeWindow : if set to true, browser window will be maximized
4. DriverVersion : sets the version of the driver, it is Latest by default. The driver version should be the same as the version of your browser.


## Structure of the framework :

Framework contains 3 separate projects.

1. Shared 
2. UITesting
3. TestingProject

## 1. Shared Project
| Class  | Description |
| ------------- | ------------- |
| TCLogger  | Contains logging functionalites. Sets the log directory to the path of the AutomationLogPath parameter taken from the runsettings file. Sets the name of the txt file to its corresponding test case code and name. Name of the txt file will also include the date time in unix time converted to seconds.   |
| Configuration  | Contains a method used to retreive a parameter from the runsettings file. |
| TestCaseData  | Contains test case data  properties. (Test Case name and code) which are being set as the log name.|


Parameter from the runsettings file can be retreived by runnning the following :
```
string Parameter = Shared.Configuration.GetSettingsParameter("ParameterName");
```

Text can be added to the log by running the following : 
```
TCLogger.Log("Corresponding text.", "Name of the element on the UI");
```

## 2. UITesting project
| Class  | Description |
| ------------- | ------------- |
| UITest  | Sets test case name and code to its corresponding values. Initializes the webdriver.|

Example of creating a new instance of the UITest :
```
 UITesting.UITest UITest = new UITesting.UITest("TC001", "Test case name");
```


| Class  | Method |Description |
| ------------- | ------------- | ------------- |
| WebDriverSetup  |DriverSetup()| Retreives the "Browser" and "MaximizeWindow" parameters from the runsettings file. Calls the SetupConfig() method and initalizes the WebDriver.|
| WebDriverSetup  |SetupConfig(IDriverConfig config, string Browser)| Sets the configuration for the corresponding browser and sets the webdriver to the driver for the corresponding browser.|
| WebDriverSetup  |DriverTeardown()| Closes the current instance of the runnning driver.|

| Class  | Method |Description |
| ------------- | ------------- | ------------- |
| WaitHelpers  |VerifyUrlDisplayed(string Url, int WaitTime = 5)| Verifies if the current url equals to given url using explicit wait. Returns bool.|
| WaitHelpers  |VerifyUrlContains(string Url, int WaitTime = 5)| Verifies if the current url contains given url using explicit wait. Returns bool.|
| WaitHelpers  |VerifyTextContains(IWebElement Element, string Text, int WaitTime = 5)| Verifies if the corresponding element contains given text using explicit wait. Returns bool.|
| WaitHelpers  |GetElement(By SearchBy, int WaitTime = 10)| Using explicit wait, waits for the given element to be visible. Returns IWebElement.|
| WaitHelpers  |Wait(int WaitTime)| Causes the current thread to suspend execution for a specified period of seconds.|



# Elements :

1. MainElement class :
MainElement class contains action and verification methods which can be used on multple Web Elements (such as buttons, textboxes, links etc..). Constructor of the MainElement class takes two parameters which are By SearchBy and string NameOfElement. SearchBy parameter determines using which locator the element will be searched by (eg. By.Id), NameOfElement determines the name of the given element (eg. Login).

2. Type Classes :
Type classes extend the MainElement class. Each WebElement has its own corresponding type class. Inside of the type classes we can write and add generic methods for actions and verifications which can be used only for the corresponding WebElement (eg. Table class will contain methods which can be used on a WebTable element).

Example type class :
```
  public class Link : MainElement
    {
        public Link(By SearchBy, string NameOfElement) : base(SearchBy, NameOfElement)
        {
        }
    }
```

# Action and verification methods :

Example method used in the Table class :
```
        /// <summary>
        /// Verifies if a column in table exists.
        /// </summary>
        /// <param name="ColumnName">Name of the column.</param>
        /// <param name="Exists">If set to false, verifies that the column in table does not exist. It is true by default</param>
        public void VerifyColumn(string ColumnName, bool Exists = true)
        {
            HeaderRow = GetHeaderRow();

            List<IWebElement> Rows = HeaderRow.FindElements(By.TagName("th")).ToList();

            if (Exists)
            {
                TCLogger.Log($"Verifying that the column '{ColumnName}' exists.", GetElementName());
                Assert.IsTrue(Rows.Any(x => x.Text.Contains(ColumnName)));
            }

            else
            {
                TCLogger.Log($"Verifying that the column '{ColumnName}' does not exist.", GetElementName());
                Assert.IsFalse(Rows.Any(x => x.Text.Contains(ColumnName)));
            }

        }
```

Each method contains a summary. Assertions are done by using Nunit. Every assertion or action in a method should be logged with a meaningful message. GetElementName() method returns the corresponding stack trace and the corresponding element name which will be logged.


## 3. TestingProject project

**Specflow :** 

Test cases are written in Gherkin language. You can find out more about specflow on the following link : https://docs.specflow.org/projects/specflow/en/latest/


**1. ExtendedElements folder** : 

Contains extended type classes. Each WebElement will have its own Extended type class which extends its corresponding type class from the UITesting project (Eg. ButtonExtended class extends Button class). Purpose of extending type clasess is that its possible to write action and verification methods relevant to the current WebPage under test. It is possible to add non generic methods which will be used only for the current WebPage under test.

Example of the extended type class :
```
     public class ButtonExtended : Button
    {
        public ButtonExtended(By SearchBy, string NameOfElement) : base(SearchBy, NameOfElement)
        {
        }
    }
```

**2. Map folder** : 

Is a page object model. It is used for storing all of the web elements. Contains several classes. Each class represents a page or a section of the WebPage under test. Each class contains corresponding elements relevant to that class (for example Login class will store web elements which are displayed only on the Login page.)

**Mapping elements** :

Element can be mapped by initializing a new Extended type. Declare the element by using the constructor that has two parameters, SearchBy and NameOfElement.
For example if the element is a Button you will initialize a new ButtonExtended type. SearchBy represents a locator (a way to find the corresponding element on the web page), NameOfElement represents the name (if the element is a button the name would be "btnSearch").

Example of initializing a new ButtonExtended type :
```
   public static ButtonExtended btnSearch = new ButtonExtended(By.ClassName("search-box-button"), "btnSearch");
```

**3. Hooks folder** : 

Contains test setup and teardown methods.

**MainHooks class** : 

Contains before (setup) and after (teardown) scenario methods which are being used in all of the test cases. 

**DemoWebShopHooks class** : 

Contains test data and a setup used for DemoWebShop test cases. 

**4. TestBook folder** : 

Contains test Specflow and Glue folders. Inside the Specflow folder is a Features folder in which DemoWebShop feature file is stored. Glue folder contains bindings for the steps inside of the feature file.



