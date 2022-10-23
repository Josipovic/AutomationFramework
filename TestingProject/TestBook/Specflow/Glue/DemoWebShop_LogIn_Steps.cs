using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestingProject.Hooks;

namespace TestingProject.TestBook.Specflow.Glue
{
    [Binding]
    public class DemoWebShop_LogIn_Steps
    {

        [Then(@"I should see Log In link that is enabled")]
        public static void ThenIShouldSeeLogInLinkThatIsEnabled()
        {
            DemoShopMap.Main.lnkLogin.VerifyDisplayed();
            DemoShopMap.Main.lnkLogin.VerifyEnabled();
        }


        [Then(@"I should see Log out link that is enabled")]
        public void ThenIShouldSeeLogOutLinkThatIsEnabled()
        {
            DemoShopMap.Main.lnkLogOut.VerifyDisplayed();
            DemoShopMap.Main.lnkLogOut.VerifyEnabled();
        }

        [When(@"I click on the log out link")]
        public void WhenIClickOnTheLogOutLink()
        {
            DemoShopMap.Main.lnkLogOut.Click();
        }

        [Then(@"Log out link should not be displayed")]
        public void ThenLogOutLinkShouldNotBeDisplayed()
        {
            DemoShopMap.Main.lnkLogOut.VerifyExists(false);
        }

        [When(@"I click on the Log in link")]
        public static void WhenIClickOnTheLogInLink()
        {
            DemoShopMap.Main.lnkLogin.Click();
        }

        [Then(@"Login page should be displayed")]
        public static void ThenLoginPageShouldBeDisplayed()
        {
            DemoShopMap.Login.LoginPage.VerifyDisplayed();
        }

        [Then(@"I should see Returning Customer section on the Login Page")]
        public static void ThenIShouldSeeReturningCustomerSectionOnTheLoginPage()
        {
            DemoShopMap.Login.wrpReturningCustomer.VerifyDisplayed();
        }

        [Then(@"I should see Email textbox that is enabled and empty in the Returning Customer section")]
        public static void ThenIShouldSeeEmailTextboxThatIsEnabledAndEmptyInTheReturningCustomerSection()
        {
            DemoShopMap.Login.txtEmail.VerifyDisplayed();
            DemoShopMap.Login.txtEmail.VerifyEnabled();
            DemoShopMap.Login.txtEmail.VerifyEmpty();
        }

        [Then(@"I should see Password textbox that is enabled and empty in the Returning Customer section")]
        public static void ThenIShouldSeePasswordTextboxThatIsEnabledAndEmptyInTheReturningCustomerSection()
        {
            DemoShopMap.Login.txtPassword.VerifyDisplayed();
            DemoShopMap.Login.txtPassword.VerifyEnabled();
            DemoShopMap.Login.txtPassword.VerifyEmpty();
        }

        [Then(@"I should see Remember me checkbox that is enabled and not checked in the Returning Customer section")]
        public static void ThenIShouldSeeRememberMeCheckboxThatIsEnabledAndNotCheckedInTheReturningCustomerSection()
        {
            DemoShopMap.Login.chkRememberMe.VerifyDisplayed();
            DemoShopMap.Login.chkRememberMe.VerifyEnabled();
            DemoShopMap.Login.chkRememberMe.VerifyChecked(false);
        }

        [Then(@"I should see Forgot Password link that is enabled in the Returning Customer section")]
        public static void ThenIShouldSeeForgotPasswordLinkThatIsEnabledInTheReturningCustomerSection()
        {
            DemoShopMap.Login.lnkForgotPassword.VerifyDisplayed();
            DemoShopMap.Login.lnkForgotPassword.VerifyEnabled();
        }

        [Then(@"I should see Log In button that is enabled in the Returning Customer section")]
        public static void ThenIShouldSeeLogInButtonThatIsEnabledInTheReturningCustomerSection()
        {
            DemoShopMap.Login.btnLogin.VerifyDisplayed();
            DemoShopMap.Login.btnLogin.VerifyEnabled();
        }

        [When(@"I enter my Email and Password on the Returning Customer section")]
        public void WhenIEnterMyEmailAndPasswordOnTheReturningCustomerSection()
        {
            DemoShopMap.Login.txtEmail.SetText(DemoWebShopHooks.Email);
            DemoShopMap.Login.txtPassword.SetText(DemoWebShopHooks.Password);
        }

        [Then(@"I should see that Returning Customer section contains my Email and Password")]
        public void ThenIShouldSeeThatReturningCustomerSectionContainsMyEmailAndPassword()
        {
            DemoShopMap.Login.txtEmail.VerifyText(DemoWebShopHooks.Email);
            DemoShopMap.Login.txtPassword.VerifyText(DemoWebShopHooks.Password);
        }

        [When(@"I click on Log In button in Returning Customer section")]
        public static void WhenIClickOnLogInButtonInReturningCustomerSection()
        {
            DemoShopMap.Login.btnLogin.Click();
        }
    }
}
