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
    public class DemoWebShop_Account_Steps
    {
        [When(@"I click on My Account link")]
        public void WhenIClickOnMyAccountLink()
        {
            DemoShopMap.Main.lnkAccount(DemoWebShopHooks.Email).Click();
        }

        [Then(@"Customer Info page should be displayed")]
        public void ThenCustomerInfoPageShouldBeDisplayed()
        {
            DemoShopMap.MyAccount.CustomerInfo.CustomerInfoPage.VerifyDisplayed();
        }

        [Then(@"I should see My Account list on the Customer Info page")]
        public void ThenIShouldSeeMyAccountListOnTheCustomerInfoPage()
        {
            DemoShopMap.MyAccount.lstMyAccount.VerifyDisplayed();
        }

        [Then(@"I should see ""([^""]*)"" link that is enabled in the My Account list")]
        public void ThenIShouldSeeLinkThatIsEnabledInTheMyAccountList(string Text)
        {
            DemoShopMap.MyAccount.lstMyAccount.VerifyElementInListDisplayed(Text);
            DemoShopMap.MyAccount.lstMyAccount.VerifyElementInListEnabled(Text);
        }

        [Then(@"I should see Customer Info section on the Customer Info page")]
        public void ThenIShouldSeeCustomerInfoSectionOnTheCustomerInfoPage()
        {
            DemoShopMap.MyAccount.CustomerInfo.wrpCustomerInfo.VerifyDisplayed();
        }

        [Then(@"I should see Male radio button option that is enabled and not selected in the Customer Info section")]
        public void ThenIShouldSeeMaleRadioButtonOptionThatIsEnabledAndNotSelectedInTheCustomerInfoSection()
        {
            DemoShopMap.MyAccount.CustomerInfo.radiobtnMale.VerifyDisplayed();
            DemoShopMap.MyAccount.CustomerInfo.radiobtnMale.VerifyEnabled();
            DemoShopMap.MyAccount.CustomerInfo.radiobtnMale.VerifySelected(false);
        }

        [Then(@"I should see Female radio button option that is enabled and not selected in the Customer Info section")]
        public void ThenIShouldSeeFemaleRadioButtonOptionThatIsEnabledAndNotSelectedInTheCustomerInfoSection()
        {
            DemoShopMap.MyAccount.CustomerInfo.radiobtnFemale.VerifyDisplayed();
            DemoShopMap.MyAccount.CustomerInfo.radiobtnFemale.VerifyEnabled();
            DemoShopMap.MyAccount.CustomerInfo.radiobtnFemale.VerifySelected(false);
        }

        [Then(@"I should see First Name textbox that is enabled and contains my First Name in the Customer Info section")]
        public void ThenIShouldSeeFirstNameTextboxThatIsEnabledAndContainsMyFirstNameInTheCustomerInfoSection()
        {
            DemoShopMap.MyAccount.CustomerInfo.txtFirstName.VerifyDisplayed();
            DemoShopMap.MyAccount.CustomerInfo.txtFirstName.VerifyEnabled();
            DemoShopMap.MyAccount.CustomerInfo.txtFirstName.VerifyText(DemoWebShopHooks.FirstName);
        }

        [Then(@"I should see Last Name textbox that is enabled and contains my Last Name in the Customer Info section")]
        public void ThenIShouldSeeLastNameTextboxThatIsEnabledAndContainsMyLastNameInTheCustomerInfoSection()
        {
            DemoShopMap.MyAccount.CustomerInfo.txtLastName.VerifyDisplayed();
            DemoShopMap.MyAccount.CustomerInfo.txtLastName.VerifyEnabled();
            DemoShopMap.MyAccount.CustomerInfo.txtLastName.VerifyText(DemoWebShopHooks.LastName);
        }

        [Then(@"I should see Email textbox that is enabled and contains my Email in the Customer Info section")]
        public void ThenIShouldSeeEmailTextboxThatIsEnabledAndContainsMyEmailInTheCustomerInfoSection()
        {
            DemoShopMap.MyAccount.CustomerInfo.txtEmail.VerifyDisplayed();
            DemoShopMap.MyAccount.CustomerInfo.txtEmail.VerifyEnabled();
            DemoShopMap.MyAccount.CustomerInfo.txtEmail.VerifyText(DemoWebShopHooks.Email);
        }

        [Then(@"I should see Save button that is enabled in the Customer Info section")]
        public void ThenIShouldSeeSaveButtonThatIsEnabledInTheCustomerInfoSection()
        {
            DemoShopMap.MyAccount.CustomerInfo.btnSave.VerifyDisplayed();
            DemoShopMap.MyAccount.CustomerInfo.btnSave.VerifyEnabled();
        }

        [When(@"I click on the ""([^""]*)"" link in the My Account list")]
        public void WhenIClickOnTheLinkInTheMyAccountList(string Text)
        {
            DemoShopMap.MyAccount.lstMyAccount.ClickOnElementInList(Text);
        }

        [Then(@"Change Password page should be displayed")]
        public void ThenChangePasswordPageShouldBeDisplayed()
        {
            DemoShopMap.MyAccount.ChangePassword.ChangePasswordPage.VerifyDisplayed();
        }

        [Then(@"I should see Change Password section on the Change Password page")]
        public void ThenIShouldSeeChangePasswordSectionOnTheChangePasswordPage()
        {
            DemoShopMap.MyAccount.ChangePassword.wrpChangePassword.VerifyDisplayed();
        }

        [Then(@"I should see Old Password textbox that is enabled and empty in the Change Password section")]
        public void ThenIShouldSeeOldPasswordTextboxThatIsEnabledAndEmptyInTheChangePasswordSection()
        {
            DemoShopMap.MyAccount.ChangePassword.txtOldPassword.VerifyDisplayed();
            DemoShopMap.MyAccount.ChangePassword.txtOldPassword.VerifyEnabled();
            DemoShopMap.MyAccount.ChangePassword.txtOldPassword.VerifyEmpty();
        }

        [Then(@"I should see New Password textbox that is enabled and empty in the Change Password section")]
        public void ThenIShouldSeeNewPasswordTextboxThatIsEnabledAndEmptyInTheChangePasswordSection()
        {
            DemoShopMap.MyAccount.ChangePassword.txtNewPassword.VerifyDisplayed();
            DemoShopMap.MyAccount.ChangePassword.txtNewPassword.VerifyEnabled();
            DemoShopMap.MyAccount.ChangePassword.txtNewPassword.VerifyEmpty();
        }

        [Then(@"I should see Confirm Password textbox that is enabled and empty in the Change Password section")]
        public void ThenIShouldSeeConfirmPasswordTextboxThatIsEnabledAndEmptyInTheChangePasswordSection()
        {
            DemoShopMap.MyAccount.ChangePassword.txtConfirmNewPassword.VerifyDisplayed();
            DemoShopMap.MyAccount.ChangePassword.txtConfirmNewPassword.VerifyEnabled();
            DemoShopMap.MyAccount.ChangePassword.txtConfirmNewPassword.VerifyEmpty();
        }

        [Then(@"I should see Change Password button that is enabled in the Change Password section")]
        public void ThenIShouldSeeChangePasswordButtonThatIsEnabledInTheChangePasswordSection()
        {
            DemoShopMap.MyAccount.ChangePassword.btnChangePassword.VerifyDisplayed();
            DemoShopMap.MyAccount.ChangePassword.btnChangePassword.VerifyEnabled();
        }

        [When(@"I enter my Password details on the Change Password section")]
        public void WhenIEnterMyPasswordDetailsOnTheChangePasswordSection()
        {
            DemoShopMap.MyAccount.ChangePassword.txtOldPassword.SetText(DemoWebShopHooks.Password);
            DemoShopMap.MyAccount.ChangePassword.txtNewPassword.SetText(DemoWebShopHooks.NewPassword);
            DemoShopMap.MyAccount.ChangePassword.txtConfirmNewPassword.SetText(DemoWebShopHooks.NewPassword);
        }

        [Then(@"I should see that Change Password section contains my Password detials")]
        public void ThenIShouldSeeThatChangePasswordSectionContainsMyPasswordDetials()
        {
            DemoShopMap.MyAccount.ChangePassword.txtOldPassword.VerifyText(DemoWebShopHooks.Password);
            DemoShopMap.MyAccount.ChangePassword.txtNewPassword.VerifyText(DemoWebShopHooks.NewPassword);
            DemoShopMap.MyAccount.ChangePassword.txtConfirmNewPassword.VerifyText(DemoWebShopHooks.NewPassword);
        }

        [When(@"I click on the Change Password button in the Change Password section")]
        public void WhenIClickOnTheChangePasswordButtonInTheChangePasswordSection()
        {
            DemoShopMap.MyAccount.ChangePassword.btnChangePassword.Click();
        }

        [Then(@"I should see Result label that contains ""([^""]*)"" text in the Change Password section")]
        public void ThenIShouldSeeResultLabelThatContainsTextInTheChangePasswordSection(string Text)
        {
            DemoShopMap.MyAccount.ChangePassword.lblResult.VerifyDisplayed();
            DemoShopMap.MyAccount.ChangePassword.lblResult.VerifyTextContains(Text);
        }
    }
}
