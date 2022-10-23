using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TestingProject.Hooks
{
    [Binding]
    public class DemoWebShopHooks
    {
        public static string FirstName;
        public static string LastName;
        public static string Email;
        public static string Password;
        public static string NewPassword;
        public static string Company = "FIVE";
        public static string Country = "United States";
        public static string State = "Alabama";
        public static string City = "TestCity";
        public static string Address1 = "Address1";
        public static string Address2 = "Address2";
        public static string Zip = "12345";
        public static string PhoneNumber = "12341234123412";
        public static string FaxNumber = "000000001";

        public string GenerateRandomString()
        {
            string FinalString = "";
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            char[] stringChars = new char[8];
            Random random = new Random();


            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return FinalString = new string(stringChars);
        }

        [BeforeScenario("DemoWebShop", Order = 1)]
        public void BeforeScenario()
        {
            DemoShopMap.Initialize();
            FirstName = "FM" + GenerateRandomString();
            LastName = "LM" + GenerateRandomString();
            Password = "Pass" + GenerateRandomString();
            Email = GenerateRandomString() + "@automation.com";


            if (MainHooks.ScenarioTags.Any(x => x.Contains("PasswordChange")))
                NewPassword = "NewPass" + GenerateRandomString();
        }
    }
}
