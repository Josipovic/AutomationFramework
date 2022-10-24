# AutomationFramework

Overview


IDE Setup :
1. Download and install Visual Studio IDE. Link : https://visualstudio.microsoft.com/vs/
2. Download and install .NET Core 6 SDK. Link : https://dotnet.microsoft.com/en-us/download/dotnet/6.0
3. After installing Visual studio IDE and .NET Core 6, you will need to add Specflow plugin into your Visual studio IDE.
Plugin can be added by clicking on Extensions -> Manage Extensions. Search for specflow and click install. You will need to reopen Visual studio IDE so the installation of the plugin can be finished.

Configure run settings :
1. Solution wide runsettings file can be configured by clicking on Test -> Configure Run Settings -> Select Solution Wide runsettings file. Select the test.runsettings file which can be found in the TestingProject folder.

Runsettings file overview :

```
<RunSettings>
  <TestRunParameters>
    <Parameter name="AutomationLogPath" value="C:\AutomationLogs" />
    <Parameter name="Browser" value="Chrome" />
    <Parameter name="MaximizeWindow" value="true" />
  </TestRunParameters>
</RunSettings>
```
Runsetting file contains mandatory settings :
1. AutomationLogPath : path where you wish to save the test case logs (logs will be saved as a txt file)
2. Browser : name of the browser on which the testing will be performed (Can be Chrome, Firefox and Edge)
3. MaximizeWindow : if set to true, browser window will be maximized


Structure of the framework :

Framework contains 3 separate projects.

1. Shared 
2. UITesting
3. TestingProject

Shared Project
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

UITesting project
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
    
