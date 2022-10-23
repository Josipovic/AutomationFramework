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
    public class DemoWebShop_Register_Steps
    {
        [When(@"I click on the Register link")]
        public static void WhenIClickOnTheRegisterLink()
        {
            DemoShopMap.Main.lnkRegister.Click();
        }

        [Then(@"I should see Register link that is enabled")]
        public static void ThenIShouldSeeRegisterLinkThatIsEnabled()
        {
            DemoShopMap.Main.lnkRegister.VerifyDisplayed();
            DemoShopMap.Main.lnkRegister.VerifyEnabled();
        }

        [Then(@"I should see that the Register section is displayed")]
        public static void ThenIShouldSeeThatTheRegisterSectionIsDisplayed()
        {
            DemoShopMap.Register.wrpRegister.VerifyDisplayed();
        }

        [Then(@"I should see Male radio button option that is enabled and not selected in the Register section")]
        public static void ThenIShouldSeeMaleRadioButtonOptionThatIsEnabledAndNotSelectedInTheRegisterSection()
        {
            DemoShopMap.Register.radiobtnMale.VerifyDisplayed();
            DemoShopMap.Register.radiobtnMale.VerifyEnabled();
            DemoShopMap.Register.radiobtnMale.VerifySelected(false);
        }

        [Then(@"I should see Female radio button option that is enabled and not selected in the Register section")]
        public static void ThenIShouldSeeFemaleRadioButtonOptionThatIsEnabledAndNotSelectedInTheRegisterSection()
        {

            DemoShopMap.Register.radiobtnFemale.VerifyDisplayed();
            DemoShopMap.Register.radiobtnFemale.VerifyEnabled();
            DemoShopMap.Register.radiobtnFemale.VerifySelected(false);
        }

        [Then(@"I should see First Name textbox that is enabled and empty in the Register Section")]
        public static void ThenIShouldSeeFirstNameTextboxThatIsEnabledAndEmptyInTheRegisterSection()
        {
            DemoShopMap.Register.txtFirstName.VerifyDisplayed();
            DemoShopMap.Register.txtFirstName.VerifyEnabled();
            DemoShopMap.Register.txtFirstName.VerifyEmpty();
        }

        [Then(@"I should see Last Name textbox that is enabled and empty in the Register Section")]
        public static void ThenIShouldSeeLastNameTextboxThatIsEnabledAndEmptyInTheRegisterSection()
        {
            DemoShopMap.Register.txtLastName.VerifyDisplayed();
            DemoShopMap.Register.txtLastName.VerifyEnabled();
            DemoShopMap.Register.txtLastName.VerifyEmpty();
        }

        [Then(@"I should see Email textbox that is enabled and empty in the Register Section")]
        public static void ThenIShouldSeeEmailTextboxThatIsEnabledAndEmptyInTheRegisterSection()
        {
            DemoShopMap.Register.txtEmail.VerifyDisplayed();
            DemoShopMap.Register.txtEmail.VerifyEnabled();
            DemoShopMap.Register.txtEmail.VerifyEmpty();
        }

        [Then(@"I should see Password textbox that is enabled and empty in the Register Section")]
        public static void ThenIShouldSeePasswordTextboxThatIsEnabledAndEmptyInTheRegisterSection()
        {
            DemoShopMap.Register.txtPassword.VerifyDisplayed();
            DemoShopMap.Register.txtPassword.VerifyEnabled();
            DemoShopMap.Register.txtPassword.VerifyEmpty();
        }

        [Then(@"I should see Confirm Password textbox that is enabled and empty in the Register Section")]
        public static void ThenIShouldSeeConfirmPasswordTextboxThatIsEnabledAndEmptyInTheRegisterSection()
        {
            DemoShopMap.Register.txtConfirmPassword.VerifyDisplayed();
            DemoShopMap.Register.txtConfirmPassword.VerifyEnabled();
            DemoShopMap.Register.txtConfirmPassword.VerifyEmpty();
        }

        [Then(@"I should see Register button that is enabled")]
        public static void ThenIShouldSeeRegisterButtonThatIsEnabled()
        {
            DemoShopMap.Register.btnRegister.VerifyDisplayed();
            DemoShopMap.Register.btnRegister.VerifyEnabled();
        }

        [When(@"I enter my Personal Details on the Register section")]
        public static void WhenIEnterMyPersonalDetailsOnTheRegisterSection()
        {
            DemoShopMap.Register.txtFirstName.SetText(DemoWebShopHooks.FirstName);
            DemoShopMap.Register.txtLastName.SetText(DemoWebShopHooks.LastName);
            DemoShopMap.Register.txtEmail.SetText(DemoWebShopHooks.Email);

        }

        [When(@"I enter my Password on the Register section")]
        public static void WhenIEnterMyPasswordOnTheRegisterSection()
        {
            DemoShopMap.Register.txtPassword.SetText(DemoWebShopHooks.Password);
            DemoShopMap.Register.txtConfirmPassword.SetText(DemoWebShopHooks.Password);
        }

        [Then(@"I should see that Register Section contains my personal Details")]
        public static void ThenIShouldSeeThatRegisterSectionContainsMyPersonalDetails()
        {
            DemoShopMap.Register.txtFirstName.VerifyText(DemoWebShopHooks.FirstName);
            DemoShopMap.Register.txtLastName.VerifyText(DemoWebShopHooks.LastName);
            DemoShopMap.Register.txtEmail.VerifyText(DemoWebShopHooks.Email);
        }

        [Then(@"I should see that Register Section contains my password")]
        public static void ThenIShouldSeeThatRegisterSectionContainsMyPassword()
        {
            DemoShopMap.Register.txtPassword.VerifyText(DemoWebShopHooks.Password);
            DemoShopMap.Register.txtConfirmPassword.VerifyText(DemoWebShopHooks.Password);
        }

        [When(@"I click on Register button")]
        public static void WhenIClickOnRegisterButton()
        {
            DemoShopMap.Register.btnRegister.Click();
        }

        [Then(@"I should see Result label that contains ""([^""]*)"" text")]
        public static void ThenIShouldSeeResultLabelThatContainsText(string Text)
        {
            DemoShopMap.Register.lblResult.VerifyDisplayed();
            DemoShopMap.Register.lblResult.VerifyTextContains(Text);
        }

        [Then(@"I should see Continue button that is enabled on the Register section")]
        public void ThenIShouldSeeContinueButtonThatIsEnabledOnTheRegisterSection()
        {
            DemoShopMap.Register.btnContinue.VerifyDisplayed();
            DemoShopMap.Register.btnContinue.VerifyEnabled();
        }

        [Then(@"Register page should be displayed")]
        public static void ThenRegisterPageShouldBeDisplayed()
        {
            DemoShopMap.Register.RegisterPage.VerifyDisplayed();
        }

        [Then(@"I should see that the Register section is displayed on the Register Page")]
        public static void ThenIShouldSeeThatTheRegisterSectionIsDisplayedOnTheRegisterPage()
        {
            DemoShopMap.Register.wrpRegister.VerifyDisplayed();
        }

        [When(@"I click on the Continue button on the Register Page")]
        public void WhenIClickOnTheContinueButtonOnTheRegisterPage()
        {
            DemoShopMap.Register.btnContinue.Click();
        }
    }
}
