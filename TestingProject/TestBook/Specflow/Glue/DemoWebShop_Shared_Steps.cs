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
    public class DemoWebShop_Shared_Steps
    {
        [Given(@"I navigate to the DemoWebShop Page")]
        public void GivenINavigateToTheDemoWebShopPage()
        {
            DemoShopMap.Main.DemoWebShop.Navigate();
            DemoShopMap.Main.DemoWebShop.VerifyDisplayed();
        }

        [When(@"I navigate to the DemoWebShop Page")]
        public void WhenINavigateToTheDemoWebShopPage()
        {
            DemoShopMap.Main.DemoWebShop.Navigate();
            DemoShopMap.Main.DemoWebShop.VerifyDisplayed();
        }

        [Then(@"DemoWebShop page should be displayed")]
        public void ThenDemoWebShopPageShouldBeDisplayed()
        {
            DemoShopMap.Main.DemoWebShop.VerifyDisplayed();
        }

        [Then(@"I should see My Account link that is enabled")]
        public void ThenIShouldSeeMyAccountLinkThatIsEnabled()
        {
            DemoShopMap.Main.lnkAccount(DemoWebShopHooks.Email).VerifyDisplayed();
            DemoShopMap.Main.lnkAccount(DemoWebShopHooks.Email).VerifyEnabled();
        }

        [When(@"I register a new user on the DemoWebShop Page")]
        public void WhenIRegisterANewUserOnTheDemoWebShopPage()
        {
            DemoWebShop_Register_Steps.ThenIShouldSeeRegisterLinkThatIsEnabled();
            DemoWebShop_LogIn_Steps.ThenIShouldSeeLogInLinkThatIsEnabled();
            DemoWebShop_Register_Steps.WhenIClickOnTheRegisterLink();
            DemoWebShop_Register_Steps.ThenRegisterPageShouldBeDisplayed();
            DemoWebShop_Register_Steps.ThenIShouldSeeThatTheRegisterSectionIsDisplayedOnTheRegisterPage();
            DemoWebShop_Register_Steps.ThenIShouldSeeMaleRadioButtonOptionThatIsEnabledAndNotSelectedInTheRegisterSection();
            DemoWebShop_Register_Steps.ThenIShouldSeeFemaleRadioButtonOptionThatIsEnabledAndNotSelectedInTheRegisterSection();
            DemoWebShop_Register_Steps.ThenIShouldSeeFirstNameTextboxThatIsEnabledAndEmptyInTheRegisterSection();
            DemoWebShop_Register_Steps.ThenIShouldSeeLastNameTextboxThatIsEnabledAndEmptyInTheRegisterSection();
            DemoWebShop_Register_Steps.ThenIShouldSeeEmailTextboxThatIsEnabledAndEmptyInTheRegisterSection();
            DemoWebShop_Register_Steps.ThenIShouldSeePasswordTextboxThatIsEnabledAndEmptyInTheRegisterSection();
            DemoWebShop_Register_Steps.ThenIShouldSeeConfirmPasswordTextboxThatIsEnabledAndEmptyInTheRegisterSection();
            DemoWebShop_Register_Steps.ThenIShouldSeeRegisterButtonThatIsEnabled();
            DemoWebShop_Register_Steps.WhenIEnterMyPersonalDetailsOnTheRegisterSection();
            DemoWebShop_Register_Steps.WhenIEnterMyPasswordOnTheRegisterSection();
            DemoWebShop_Register_Steps.ThenIShouldSeeThatRegisterSectionContainsMyPersonalDetails();
            DemoWebShop_Register_Steps.ThenIShouldSeeThatRegisterSectionContainsMyPassword();
            DemoWebShop_Register_Steps.WhenIClickOnRegisterButton();
            DemoWebShop_Register_Steps.ThenIShouldSeeResultLabelThatContainsText("Your registration completed");

        }

        [When(@"I Login on the DemoWebShop Page")]
        public void WhenILoginOnTheDemoWebShopPage()
        {
            string Password = DemoWebShopHooks.Password;

            if (MainHooks.ScenarioTags.Any(x => x.Contains("PasswordChange")))
                Password = DemoWebShopHooks.NewPassword;

            DemoWebShop_LogIn_Steps.ThenIShouldSeeLogInLinkThatIsEnabled();
            DemoWebShop_LogIn_Steps.WhenIClickOnTheLogInLink();
            DemoWebShop_LogIn_Steps.ThenLoginPageShouldBeDisplayed();
            DemoWebShop_LogIn_Steps.ThenIShouldSeeReturningCustomerSectionOnTheLoginPage();
            DemoWebShop_LogIn_Steps.ThenIShouldSeeEmailTextboxThatIsEnabledAndEmptyInTheReturningCustomerSection();
            DemoWebShop_LogIn_Steps.ThenIShouldSeePasswordTextboxThatIsEnabledAndEmptyInTheReturningCustomerSection();
            DemoWebShop_LogIn_Steps.ThenIShouldSeeRememberMeCheckboxThatIsEnabledAndNotCheckedInTheReturningCustomerSection();
            DemoWebShop_LogIn_Steps.ThenIShouldSeeForgotPasswordLinkThatIsEnabledInTheReturningCustomerSection();
            DemoWebShop_LogIn_Steps.ThenIShouldSeeLogInButtonThatIsEnabledInTheReturningCustomerSection();



            DemoShopMap.Login.txtEmail.SetText(DemoWebShopHooks.Email);
            DemoShopMap.Login.txtPassword.SetText(Password);
            DemoShopMap.Login.txtEmail.VerifyText(DemoWebShopHooks.Email);
            DemoShopMap.Login.txtPassword.VerifyText(Password);

            DemoWebShop_LogIn_Steps.WhenIClickOnLogInButtonInReturningCustomerSection();

        }
    }
}
