using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestingProject.Hooks;
using UITesting.Helpers;

namespace TestingProject.TestBook.Specflow.Glue
{
    [Binding]
    public class DemoWebShop_Order_Steps
    {
        [Then(@"I should see Shopping cart link that is enabled and contains ""([^""]*)"" text")]
        public void ThenIShouldSeeShoppingCartLinkThatIsEnabledAndContainsText(string Text)
        {
            DemoShopMap.Main.lnkShoppingCart.VerifyDisplayed();
            DemoShopMap.Main.lnkShoppingCart.VerifyEnabled();
            DemoShopMap.Main.lnkShoppingCart.VerifyTextContains(Text);
        }


        [Then(@"I should see Add to cart button that is enabled in the Overview section")]
        public static void ThenIShouldSeeAddToCartButtonThatIsEnabledInTheOverviewSection()
        {
            DemoShopMap.Product.btnAddToCart.VerifyDisplayed();
            DemoShopMap.Product.btnAddToCart.VerifyEnabled();
        }

        [Then(@"I should see Email a friend button that is enabled in the Overview section")]
        public static void ThenIShouldSeeEmailAFriendButtonThatIsEnabledInTheOverviewSection()
        {
            DemoShopMap.Product.btnEmailAFriend.VerifyDisplayed();
            DemoShopMap.Product.btnEmailAFriend.VerifyEnabled();
        }

        [Then(@"I should see Add to compare list button that is enabled in the Overview section")]
        public static void ThenIShouldSeeAddToCompareListButtonThatIsEnabledInTheOverviewSection()
        {
            DemoShopMap.Product.btnAddToCompareList.VerifyDisplayed();
            DemoShopMap.Product.btnAddToCompareList.VerifyEnabled();
        }

        [Then(@"I should see Qty textbox that is enabled and contains ""([^""]*)"" text in the Overview section")]
        public static void ThenIShouldSeeQtyTextboxThatIsEnabledAndContainsTextInTheOverviewSection(string Text)
        {
            DemoShopMap.Product.txtQty.VerifyDisplayed();
            DemoShopMap.Product.txtQty.VerifyEnabled();
            DemoShopMap.Product.txtQty.VerifyTextContains(Text);

        }



        [When(@"I click on the Add to cart button in the Overview section")]
        public void WhenIClickOnTheAddToCartButtonInTheOverviewSection()
        {
            DemoShopMap.Product.btnAddToCart.Click();
        }

        [When(@"I click on the Shopping cart link")]
        public void WhenIClickOnTheShoppingCartLink()
        {
            DemoShopMap.Main.lnkShoppingCart.Click();
        }

        [Then(@"I should see Cart table that is not empty")]
        public void ThenIShouldSeeCartTableThatIsNotEmpty()
        {
            DemoShopMap.Cart.tblCart.VerifyDisplayed();
            DemoShopMap.Cart.tblCart.VerifyEmpty(false);
        }

        [Then(@"I should see that Cart table contains ""([^""]*)"", ""([^""]*)"", ""([^""]*)"", ""([^""]*)"" and ""([^""]*)"" columns")]
        public void ThenIShouldSeeThatCartTableContainsAndColumns(string Remove, string Products, string Price, string Qty, string Total)
        {
            DemoShopMap.Cart.tblCart.VerifyColumn(Remove);
            DemoShopMap.Cart.tblCart.VerifyColumn(Products);
            DemoShopMap.Cart.tblCart.VerifyColumn(Price);
            DemoShopMap.Cart.tblCart.VerifyColumn(Qty);
            DemoShopMap.Cart.tblCart.VerifyColumn(Total);
        }

        [Then(@"I should see that ""([^""]*)"" column contains ""([^""]*)"" text in the Cart table")]
        public void ThenIShouldSeeThatColumnContainsTextInTheCartTable(string CoulmnName, string CellValue)
        {
            DemoShopMap.Cart.tblCart.FindCellByText(CoulmnName, CellValue);
        }

        [Then(@"I should see Update Shopping Cart button that is enabled")]
        public void ThenIShouldSeeUpdateShoppingCartButtonThatIsEnabled()
        {
            DemoShopMap.Cart.btnUpdateShoppingCart.VerifyDisplayed();
            DemoShopMap.Cart.btnUpdateShoppingCart.VerifyEnabled();
        }

        [Then(@"I should see Continue Shopping button that is enabled")]
        public void ThenIShouldSeeContinueShoppingButtonThatIsEnabled()
        {
            DemoShopMap.Cart.btnContinueShopping.VerifyDisplayed();
            DemoShopMap.Cart.btnContinueShopping.VerifyEnabled();
        }

        [Then(@"I should see Enter your coupon here textbox that is enabled and empty")]
        public void ThenIShouldSeeEnterYourCouponHereTextboxThatIsEnabledAndEmpty()
        {
            DemoShopMap.Cart.txtEnterYourCoupon.VerifyDisplayed();
            DemoShopMap.Cart.txtEnterYourCoupon.VerifyEnabled();
            DemoShopMap.Cart.txtEnterYourCoupon.VerifyEmpty();
        }

        [Then(@"I should see Apply coupon button that is enabled")]
        public void ThenIShouldSeeApplyCouponButtonThatIsEnabled()
        {
            DemoShopMap.Cart.btnApplyCoupon.VerifyDisplayed();
            DemoShopMap.Cart.btnApplyCoupon.VerifyEnabled();
        }

        [Then(@"I should see Add gift card textbox that is enabled and empty")]
        public void ThenIShouldSeeAddGiftCardTextboxThatIsEnabledAndEmpty()
        {
            DemoShopMap.Cart.txtEnterGiftCardCode.VerifyDisplayed();
            DemoShopMap.Cart.txtEnterGiftCardCode.VerifyEnabled();
            DemoShopMap.Cart.txtEnterGiftCardCode.VerifyEmpty();
        }

        [Then(@"I should see Add gift card button that is enabled")]
        public void ThenIShouldSeeAddGiftCardButtonThatIsEnabled()
        {
            DemoShopMap.Cart.btnAddGiftCardCode.VerifyDisplayed();
            DemoShopMap.Cart.btnAddGiftCardCode.VerifyEnabled();
        }

        [Then(@"I should see Select country dropdown that is enabled with ""([^""]*)"" option selected")]
        public void ThenIShouldSeeSelectCountryDropdownThatIsEnabledWithOptionSelected(string Option)
        {
            DemoShopMap.Cart.ddCountry.VerifyDisplayed();
            DemoShopMap.Cart.ddCountry.VerifyEnabled();
            DemoShopMap.Cart.ddCountry.VerifyOptionSelected(Option);
        }

        [Then(@"I should see State/Province dropdown that is enabled with ""([^""]*)"" option selected")]
        public void ThenIShouldSeeStateProvinceDropdownThatIsEnabledWithOptionSelected(string Option)
        {
            DemoShopMap.Cart.ddState.VerifyDisplayed();
            DemoShopMap.Cart.ddState.VerifyEnabled();
            DemoShopMap.Cart.ddState.VerifyOptionSelected(Option);
        }

        [Then(@"I should see Zip/Postal code textbox that is enabled and empty")]
        public void ThenIShouldSeeZipPostalCodeTextboxThatIsEnabledAndEmpty()
        {
            DemoShopMap.Cart.txtZip.VerifyDisplayed();
            DemoShopMap.Cart.txtZip.VerifyEnabled();
            DemoShopMap.Cart.txtZip.VerifyEmpty();
        }

        [Then(@"I should see Estimate shipping button that is enabled")]
        public void ThenIShouldSeeEstimateShippingButtonThatIsEnabled()
        {
            DemoShopMap.Cart.btnEstimateShipping.VerifyDisplayed();
            DemoShopMap.Cart.btnEstimateShipping.VerifyEnabled();
        }

        [Then(@"I should see Terms Of Service checkbox that is enabled and not checked")]
        public void ThenIShouldSeeTermsOfServiceCheckboxThatIsEnabledAndNotChecked()
        {
            DemoShopMap.Cart.chkTermsOfService.VerifyDisplayed();
            DemoShopMap.Cart.chkTermsOfService.VerifyEnabled();
            DemoShopMap.Cart.chkTermsOfService.VerifyChecked(false);
        }

        [When(@"I click on Terms Of Service checkbox")]
        public void WhenIClickOnTermsOfServiceCheckbox()
        {
            DemoShopMap.Cart.chkTermsOfService.Click();
        }


        [Then(@"I should see Checkout button that is enabled")]
        public void ThenIShouldSeeCheckoutButtonThatIsEnabled()
        {
            DemoShopMap.Cart.btnCheckout.VerifyDisplayed();
            DemoShopMap.Cart.btnCheckout.VerifyEnabled();
        }

        [When(@"I click on the Checkout button")]
        public void WhenIClickOnTheCheckoutButton()
        {
            DemoShopMap.Cart.btnCheckout.Click();
        }

        [Then(@"I should see Billing Adress details on the Checkout page")]
        public void ThenIShouldSeeBillingAdressDetailsOnTheCheckoutPage()
        {
            DemoShopMap.Checkout.BillingAddress.txtFirstName.VerifyDisplayed();
            DemoShopMap.Checkout.BillingAddress.txtFirstName.VerifyEnabled();
            DemoShopMap.Checkout.BillingAddress.txtFirstName.VerifyText(DemoWebShopHooks.FirstName);

            DemoShopMap.Checkout.BillingAddress.txtLastName.VerifyDisplayed();
            DemoShopMap.Checkout.BillingAddress.txtLastName.VerifyEnabled();
            DemoShopMap.Checkout.BillingAddress.txtLastName.VerifyText(DemoWebShopHooks.LastName);

            DemoShopMap.Checkout.BillingAddress.txtEmail.VerifyDisplayed();
            DemoShopMap.Checkout.BillingAddress.txtEmail.VerifyEnabled();
            DemoShopMap.Checkout.BillingAddress.txtEmail.VerifyText(DemoWebShopHooks.Email);

            DemoShopMap.Checkout.BillingAddress.txtCompany.VerifyDisplayed();
            DemoShopMap.Checkout.BillingAddress.txtCompany.VerifyEnabled();
            DemoShopMap.Checkout.BillingAddress.txtCompany.VerifyEmpty();

            DemoShopMap.Checkout.BillingAddress.ddCountry.VerifyDisplayed();
            DemoShopMap.Checkout.BillingAddress.ddCountry.VerifyEnabled();
            DemoShopMap.Checkout.BillingAddress.ddCountry.VerifyOptionSelected("Select country");

            DemoShopMap.Checkout.BillingAddress.ddState.VerifyDisplayed();
            DemoShopMap.Checkout.BillingAddress.ddState.VerifyEnabled();
            DemoShopMap.Checkout.BillingAddress.ddState.VerifyOptionSelected("Other (Non US)");

            DemoShopMap.Checkout.BillingAddress.txtCity.VerifyDisplayed();
            DemoShopMap.Checkout.BillingAddress.txtCity.VerifyEnabled();
            DemoShopMap.Checkout.BillingAddress.txtCity.VerifyEmpty();

            DemoShopMap.Checkout.BillingAddress.txtAddress1.VerifyDisplayed();
            DemoShopMap.Checkout.BillingAddress.txtAddress1.VerifyEnabled();
            DemoShopMap.Checkout.BillingAddress.txtAddress1.VerifyEmpty();

            DemoShopMap.Checkout.BillingAddress.txtAddress2.VerifyDisplayed();
            DemoShopMap.Checkout.BillingAddress.txtAddress2.VerifyEnabled();
            DemoShopMap.Checkout.BillingAddress.txtAddress2.VerifyEmpty();

            DemoShopMap.Checkout.BillingAddress.txtZip.VerifyDisplayed();
            DemoShopMap.Checkout.BillingAddress.txtZip.VerifyEnabled();
            DemoShopMap.Checkout.BillingAddress.txtZip.VerifyEmpty();

            DemoShopMap.Checkout.BillingAddress.txtPhoneNumber.VerifyDisplayed();
            DemoShopMap.Checkout.BillingAddress.txtPhoneNumber.VerifyEnabled();
            DemoShopMap.Checkout.BillingAddress.txtPhoneNumber.VerifyEmpty();

            DemoShopMap.Checkout.BillingAddress.txtFaxNumber.VerifyDisplayed();
            DemoShopMap.Checkout.BillingAddress.txtFaxNumber.VerifyEnabled();
            DemoShopMap.Checkout.BillingAddress.txtFaxNumber.VerifyEmpty();

        }


        [Then(@"I should see Continue button that is enabled in the Shipping Address section")]
        public void ThenIShouldSeeContinueButtonThatIsEnabledInTheShippingAddressSection()
        {
            DemoShopMap.Checkout.ShippingAddress.btnContinue.VerifyDisplayed();
            DemoShopMap.Checkout.ShippingAddress.btnContinue.VerifyEnabled();
        }

        [When(@"I click on the Continue button in the Shipping Address section")]
        public void WhenIClickOnTheContinueButtonInTheShippingAddressSection()
        {
            DemoShopMap.Checkout.ShippingAddress.btnContinue.Click();
        }


        [Then(@"I should see Continue button that is enabled in the Billing Address section")]
        public void ThenIShouldSeeContinueButtonThatIsEnabledInTheBillingAddressSection()
        {
            DemoShopMap.Checkout.BillingAddress.btnContinue.VerifyDisplayed();
            DemoShopMap.Checkout.BillingAddress.btnContinue.VerifyEnabled();
        }

        [When(@"I click on the Continue button on the Billing Address section")]
        public void WhenIClickOnTheContinueButtonOnTheBillingAddressSection()
        {
            DemoShopMap.Checkout.BillingAddress.btnContinue.Click();
        }


        [When(@"I enter my Billing details")]
        public void WhenIEnterMyBillingDetails()
        {
            DemoShopMap.Checkout.BillingAddress.txtCompany.SetText(DemoWebShopHooks.Company);

            DemoShopMap.Checkout.BillingAddress.ddCountry.SelectOptionByText(DemoWebShopHooks.Country);

            WaitHelpers.Wait(4);

            DemoShopMap.Checkout.BillingAddress.ddState.SelectOptionByText(DemoWebShopHooks.State);

            DemoShopMap.Checkout.BillingAddress.txtCity.SetText(DemoWebShopHooks.City);

            DemoShopMap.Checkout.BillingAddress.txtAddress1.SetText(DemoWebShopHooks.Address1);

            DemoShopMap.Checkout.BillingAddress.txtAddress2.SetText(DemoWebShopHooks.Address2);

            DemoShopMap.Checkout.BillingAddress.txtZip.SetText(DemoWebShopHooks.Zip);

            DemoShopMap.Checkout.BillingAddress.txtPhoneNumber.SetText(DemoWebShopHooks.PhoneNumber);

            DemoShopMap.Checkout.BillingAddress.txtFaxNumber.SetText(DemoWebShopHooks.FaxNumber);
        }

        [Then(@"I should see that Checkout page contains my Billing details")]
        public void ThenIShouldSeeThatCheckoutPageContainsMyBillingDetails()
        {
            DemoShopMap.Checkout.BillingAddress.txtCompany.VerifyText(DemoWebShopHooks.Company);

            DemoShopMap.Checkout.BillingAddress.ddCountry.VerifyOptionSelected(DemoWebShopHooks.Country);

            DemoShopMap.Checkout.BillingAddress.ddState.VerifyOptionSelected(DemoWebShopHooks.State);

            DemoShopMap.Checkout.BillingAddress.txtCity.VerifyText(DemoWebShopHooks.City);

            DemoShopMap.Checkout.BillingAddress.txtAddress1.VerifyText(DemoWebShopHooks.Address1);

            DemoShopMap.Checkout.BillingAddress.txtAddress2.VerifyText(DemoWebShopHooks.Address2);

            DemoShopMap.Checkout.BillingAddress.txtZip.VerifyText(DemoWebShopHooks.Zip);

            DemoShopMap.Checkout.BillingAddress.txtPhoneNumber.VerifyText(DemoWebShopHooks.PhoneNumber);

            DemoShopMap.Checkout.BillingAddress.txtFaxNumber.VerifyText(DemoWebShopHooks.FaxNumber);
        }


        [Then(@"I should see Shipping Address dropdown that is enabled and contains my address details")]
        public void ThenIShouldSeeShippingAddressDropdownThatIsEnabledAndContainsMyAddressDetails()
        {
            DemoShopMap.Checkout.ShippingAddress.ddShippingAddress.VerifyOptionSelectedContains(DemoWebShopHooks.FirstName);
            DemoShopMap.Checkout.ShippingAddress.ddShippingAddress.VerifyOptionSelectedContains(DemoWebShopHooks.LastName);
        }

        [Then(@"I should see In Store Pickup checkbox that is enabled and not checked")]
        public void ThenIShouldSeeInStorePickupCheckboxThatIsEnabledAndNotChecked()
        {
            DemoShopMap.Checkout.ShippingAddress.chkPickUpInStore.VerifyDisplayed();
            DemoShopMap.Checkout.ShippingAddress.chkPickUpInStore.VerifyEnabled();
            DemoShopMap.Checkout.ShippingAddress.chkPickUpInStore.VerifyChecked(false);
        }

        [Then(@"I should see Shipping Method list")]
        public void ThenIShouldSeeShippingMethodList()
        {
            DemoShopMap.Checkout.ShippingMethod.lstShippingMethod.VerifyDisplayed();
        }

        [Then(@"I should see ""([^""]*)"" radio button that is enabled in the Shipping method list")]
        public void ThenIShouldSeeRadioButtonThatIsEnabledInTheShippingMethodList(string RadioButton)
        {
            DemoShopMap.Checkout.ShippingMethod.lstShippingMethod.VerifyElementInListDisplayed(RadioButton);
            DemoShopMap.Checkout.ShippingMethod.lstShippingMethod.VerifyElementInListEnabled(RadioButton);
        }

        [When(@"I click on the ""([^""]*)"" radio button in the Shipping method list")]
        public void WhenIClickOnTheRadioButtonInTheShippingMethodList(string RadioButton)
        {
            DemoShopMap.Checkout.ShippingMethod.lstShippingMethod.ClickOnElementInList(RadioButton);
        }

        [Then(@"I should see Payment Method list")]
        public void ThenIShouldSeePaymentMethodList()
        {
            DemoShopMap.Checkout.PaymentMethod.lstPaymentMethod.VerifyDisplayed();
        }

        [Then(@"I should see ""([^""]*)"" radio button that is enabled in the Payment Method list")]
        public void ThenIShouldSeeRadioButtonThatIsEnabledInThePaymentMethodList(string RadioButton)
        {
            DemoShopMap.Checkout.PaymentMethod.lstPaymentMethod.VerifyElementInListDisplayed(RadioButton);
            DemoShopMap.Checkout.PaymentMethod.lstPaymentMethod.VerifyElementInListEnabled(RadioButton);
        }

        [When(@"I click on the ""([^""]*)"" radio button in the Payment Method list")]
        public void WhenIClickOnTheRadioButtonInThePaymentMethodList(string RadioButton)
        {
            DemoShopMap.Checkout.PaymentMethod.lstPaymentMethod.ClickOnElementInList(RadioButton);
        }

        [Then(@"I should see Payment Information section")]
        public void ThenIShouldSeePaymentInformationSection()
        {
            DemoShopMap.Checkout.PaymentInformation.wrpPaymentInformation.VerifyDisplayed();
        }


        [Then(@"I should see Billing Info list that is not empty")]
        public void ThenIShouldSeeBillingInfoListThatIsNotEmpty()
        {

            DemoShopMap.Checkout.ConfirmOrder.lstBillingInfo.VerifyDisplayed();
            DemoShopMap.Checkout.ConfirmOrder.lstBillingInfo.VerifyEmpty(false);
        }

        [Then(@"I should see Shipping Info list that is not empty")]
        public void ThenIShouldSeeShippingInfoListThatIsNotEmpty()
        {
            DemoShopMap.Checkout.ConfirmOrder.lstShippingInfo.VerifyDisplayed();
            DemoShopMap.Checkout.ConfirmOrder.lstShippingInfo.VerifyEmpty(false);
        }

        [Then(@"I should see Cart table that is not empty on the CheckoutPage")]
        public void ThenIShouldSeeCartTableThatIsNotEmptyOnTheCheckoutPage()
        {
            DemoShopMap.Checkout.ConfirmOrder.tblCart.VerifyDisplayed();
            DemoShopMap.Checkout.ConfirmOrder.tblCart.VerifyEmpty(false);
        }

        [Then(@"I should see Confirm button that is enabled")]
        public void ThenIShouldSeeConfirmButtonThatIsEnabled()
        {
            DemoShopMap.Checkout.ConfirmOrder.btnConfirm.VerifyDisplayed();
            DemoShopMap.Checkout.ConfirmOrder.btnConfirm.VerifyEnabled();
        }

        [When(@"I click on the Confirm button")]
        public void WhenIClickOnTheConfirmButton()
        {
            DemoShopMap.Checkout.ConfirmOrder.btnConfirm.Click();
        }

        [Then(@"I should see Continue button that is enabled in the Shipping method section")]
        public void ThenIShouldSeeContinueButtonThatIsEnabledInTheShippingMethodSection()
        {
            DemoShopMap.Checkout.ShippingMethod.btnContinue.VerifyDisplayed();
            DemoShopMap.Checkout.ShippingMethod.btnContinue.VerifyEnabled();
        }

        [Then(@"I should see Back link that is enabled in the Shipping Method section")]
        public void ThenIShouldSeeBackLinkThatIsEnabledInTheShippingMethodSection()
        {
            DemoShopMap.Checkout.ShippingMethod.lnkBack.VerifyDisplayed();
            DemoShopMap.Checkout.ShippingMethod.lnkBack.VerifyEnabled();
        }

        [When(@"I click on the Continue button in the Shipping method section")]
        public void WhenIClickOnTheContinueButtonInTheShippingMethodSection()
        {
            DemoShopMap.Checkout.ShippingMethod.btnContinue.Click();
        }

        [Then(@"I should see Back link that is enabled in the Payment Method section")]
        public void ThenIShouldSeeBackLinkThatIsEnabledInThePaymentMethodSection()
        {
            DemoShopMap.Checkout.PaymentMethod.lnkBack.VerifyDisplayed();
            DemoShopMap.Checkout.PaymentMethod.lnkBack.VerifyEnabled();
        }

        [Then(@"I should see Continue button that is enabled in the Payment Method section")]
        public void ThenIShouldSeeContinueButtonThatIsEnabledInThePaymentMethodSection()
        {
            DemoShopMap.Checkout.PaymentMethod.btnContinue.VerifyDisplayed();
            DemoShopMap.Checkout.PaymentMethod.btnContinue.VerifyEnabled();
        }

        [When(@"I click on the Continue button in the Payment Method section")]
        public void WhenIClickOnTheContinueButtonInThePaymentMethodSection()
        {
            DemoShopMap.Checkout.PaymentMethod.btnContinue.Click();
        }

        [Then(@"I should see Back link that is enabled in the Payment Information section")]
        public void ThenIShouldSeeBackLinkThatIsEnabledInThePaymentInformationSection()
        {
            DemoShopMap.Checkout.PaymentInformation.lnkBack.VerifyDisplayed();
            DemoShopMap.Checkout.PaymentInformation.lnkBack.VerifyEnabled();
        }

        [Then(@"I should see Continue button that is enabled in the Payment Information section")]
        public void ThenIShouldSeeContinueButtonThatIsEnabledInThePaymentInformationSection()
        {
            DemoShopMap.Checkout.PaymentInformation.btnContinue.VerifyDisplayed();
            DemoShopMap.Checkout.PaymentInformation.btnContinue.VerifyEnabled();
        }

        [Then(@"I should see Info label that contains ""([^""]*)"" text in the Payment Information section")]
        public void ThenIShouldSeeInfoLabelThatContainsTextInThePaymentInformationSection(string Text)
        {
            DemoShopMap.Checkout.PaymentInformation.lblInfo.VerifyTextContains(Text);
        }

        [When(@"I click on the Continue button in the Payment Information section")]
        public void WhenIClickOnTheContinueButtonInThePaymentInformationSection()
        {
            DemoShopMap.Checkout.PaymentInformation.btnContinue.Click();
        }

        [Then(@"I should see Back link that is enabled in the Shipping address section")]
        public void ThenIShouldSeeBackLinkThatIsEnabledInTheShippingAddressSection()
        {
            DemoShopMap.Checkout.ShippingAddress.lnkBack.VerifyDisplayed();
            DemoShopMap.Checkout.ShippingAddress.lnkBack.VerifyEnabled();
        }

        [Then(@"I should see Page title label that contains ""([^""]*)"" text")]
        public void ThenIShouldSeePageTitleLabelThatContainsText(string Text)
        {
            WaitHelpers.Wait(4);
            DemoShopMap.Checkout.CheckoutCompleted.lblPageTitle.VerifyDisplayed();
            DemoShopMap.Checkout.CheckoutCompleted.lblPageTitle.VerifyTextContains(Text);
        }

        [Then(@"I should see Order completed section")]
        public void ThenIShouldSeeOrderCompletedSection()
        {
            DemoShopMap.Checkout.CheckoutCompleted.wrpOrderCompleted.VerifyDisplayed();
        }

        [Then(@"I should see Title label that contains ""([^""]*)"" text")]
        public void ThenIShouldSeeTitleLabelThatContainsText(string Text)
        {
            DemoShopMap.Checkout.CheckoutCompleted.lblTitle.VerifyDisplayed();
            DemoShopMap.Checkout.CheckoutCompleted.lblTitle.VerifyTextContains(Text);
        }

        [Then(@"I should see Continue button that is enabled in the Order completed section")]
        public void ThenIShouldSeeContinueButtonThatIsEnabledInTheOrderCompletedSection()
        {
            DemoShopMap.Checkout.CheckoutCompleted.btnContinue.VerifyDisplayed();
            DemoShopMap.Checkout.CheckoutCompleted.btnContinue.VerifyEnabled();
        }


    }
}
