using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs;
using WebDriverManager.DriverConfigs.Impl;

namespace UITesting
{
    public class WebDriverSetup
    {

        public static IWebDriver WebDriver { get; set; }
        public static DriverOptions DriverOptions { get; set; }

        private static void SetupConfig(IDriverConfig config, string Browser)
        {
            new DriverManager().SetUpDriver(config);

            switch (Browser.ToLower())
            {
                case "chrome":
                    WebDriver = new ChromeDriver();
                    break;
                case "firefox":
                    WebDriver = new FirefoxDriver();
                    break;
                case "edge":
                    WebDriver = new EdgeDriver();
                    break;
                default:
                    WebDriver = null;
                    Console.WriteLine("Driver is null");
                    break;
            }
        }

        public static void DriverSetup()
        {
            string Browser = Shared.Configuration.GetSettingsParameter("Browser");
            string MaximizeWIndow = Shared.Configuration.GetSettingsParameter("MaximizeWindow").Equals("false") ? "false" : "true";


            if (Browser.ToLower().Equals("chrome".ToLower()))
                SetupConfig(new ChromeConfig { }, Browser);

            if (Browser.ToLower().Equals("firefox".ToLower()))
                SetupConfig(new FirefoxConfig { }, Browser);

            if (Browser.ToLower().Equals("edge".ToLower()))
                SetupConfig(new EdgeConfig { }, Browser);

            Console.WriteLine("Driver setup complete");

            if (MaximizeWIndow.Equals("true"))
                WebDriver.Manage().Window.Maximize();

        }

        public static void DriverTearDown()
        {
            if (WebDriver != null)
            {
                WebDriver.Close();
                WebDriver.Quit();
                Console.WriteLine("WebDriver closed");
            }
            else
                Console.WriteLine("No webdriver instances running");

        }
    }
}
