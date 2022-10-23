using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.ExtendedElements;

namespace TestingProject
{
    public class DemoShopMap
    {
        public static void Initialize()
        {
            PageExtended.MainPage = "https://demowebshop.tricentis.com/";
        }
        public static class Main
        {
            public static PageExtended DemoWebShop = new PageExtended("", "DemoWebhop");
            public static LinkExtended lnkRegister = new LinkExtended(By.LinkText("Register"), "lnkRegister");
            public static LinkExtended lnkLogin = new LinkExtended(By.LinkText("Log in"), "lnkLogin");
            public static LinkExtended lnkLogOut = new LinkExtended(By.LinkText("Log out"), "lnkLogOut");
            public static LinkExtended lnkShoppingCart = new LinkExtended(By.Id("topcartlink"), "lnkShoppingCart");
            public static TextboxExtended txtSearch = new TextboxExtended(By.Id("small-searchterms"), "txtSearch");
            public static ButtonExtended btnSearch = new ButtonExtended(By.ClassName("search-box-button"), "btnSearch");
            public static ListExtended lstTopMenu = new ListExtended(By.ClassName("top-menu"), By.TagName("li"), "lstTopMenu");
            public static LinkExtended lnkAccount(string Account) => new LinkExtended(By.LinkText(Account), "lnkAccount");

        }

        public static class Search
        {
            public static PageExtended SearchPage(string Page) => new PageExtended(Page, "SearchPage");
            public static LabelExtended lblPageTitle = new LabelExtended(By.ClassName("page-title"), "lblPageTitle");
            public static WrapperExtended wrpProductSelectors = new WrapperExtended(By.ClassName("product-selectors"), "wrpProductSelectors");
            public static WrapperExtended wrpProductFilters = new WrapperExtended(By.ClassName("product-filters-wrapper"), "wrpProductFilters");
            public static WrapperExtended wrpSearchInput = new WrapperExtended(By.ClassName("search-input"), "wrpSearchInput");
            public static WrapperExtended wrpSearchResults = new WrapperExtended(By.ClassName("search-results"), "wrpSearchResults");
            public static CheckboxExtended chkAdvancedSearch = new CheckboxExtended(By.Id("As"), "chkAdvancedSearch");
            public static ListExtended lstProducts = new ListExtended(By.ClassName("product-grid"), By.ClassName("item-box"), "lstProducts");
            public static TextboxExtended txtSearchKeyword = new TextboxExtended(By.Id("Q"), "txtSearchKeyword");
        }

        public static class Register
        {
            public static PageExtended RegisterPage = new PageExtended("register", "RegisterPage");
            public static WrapperExtended wrpRegister = new WrapperExtended(By.ClassName("registration-page"), "wrpRegister");
            public static RadioButtonExtended radiobtnMale = new RadioButtonExtended(By.Id("gender-male"), "radiobtnMale");
            public static RadioButtonExtended radiobtnFemale = new RadioButtonExtended(By.Id("gender-female"), "radiobtnFemale");
            public static TextboxExtended txtFirstName = new TextboxExtended(By.Id("FirstName"), "txtFirstName");
            public static TextboxExtended txtLastName = new TextboxExtended(By.Id("LastName"), "txtLastName");
            public static TextboxExtended txtEmail = new TextboxExtended(By.Id("Email"), "txtEmail");
            public static TextboxExtended txtPassword = new TextboxExtended(By.Id("Password"), "txtPassword");
            public static TextboxExtended txtConfirmPassword = new TextboxExtended(By.Id("ConfirmPassword"), "txtConfirmPassword");
            public static ButtonExtended btnRegister = new ButtonExtended(By.Id("register-button"), "btnRegister");
            public static LabelExtended lblResult = new LabelExtended(By.ClassName("result"), "lblResult");
            public static ButtonExtended btnContinue = new ButtonExtended(By.ClassName("register-continue-button"), "btnContinue");
        }

        public static class Product
        {
            public static WrapperExtended wrpOverview = new WrapperExtended(By.ClassName("overview"), "wrpOverview");
            public static WrapperExtended wrpFullDescription = new WrapperExtended(By.ClassName("full-description"), "wrpFullDescription");
            public static LabelExtended lblProductName = new LabelExtended(By.ClassName("product-name"), "lblProductName");
            public static ButtonExtended btnAddToCart = new ButtonExtended(By.XPath("//*[starts-with(@id,'add-to-cart-button')]"), "btnAddToCart");
            public static ButtonExtended btnEmailAFriend = new ButtonExtended(By.ClassName("email-a-friend-button"), "btnEmailAFriend");
            public static ButtonExtended btnAddToCompareList = new ButtonExtended(By.ClassName("add-to-compare-list-button"), "btnAddToCompareList");
            public static TextboxExtended txtQty = new TextboxExtended(By.XPath("//*[starts-with(@id,'addtocart')]"), "txtQty");
        }
    

        public static class Login
        {
            public static PageExtended LoginPage = new PageExtended("login", "LoginPage");
            public static WrapperExtended wrpReturningCustomer = new WrapperExtended(By.ClassName("returning-wrapper"), "wrpReturningCustomer");
            public static TextboxExtended txtEmail = new TextboxExtended(By.Id("Email"), "txtEmail");
            public static TextboxExtended txtPassword = new TextboxExtended(By.Id("Password"), "txtPassword");
            public static CheckboxExtended chkRememberMe = new CheckboxExtended(By.Id("RememberMe"), "chkRememberMe");
            public static LinkExtended lnkForgotPassword = new LinkExtended(By.LinkText("Forgot password?"), "lnkForgotPassword");
            public static ButtonExtended btnLogin = new ButtonExtended(By.ClassName("login-button"), "btnLogin");
        }

        public static class Cart
        {
            public static TableExtended tblCart = new TableExtended(By.ClassName("cart"), "tblCart");
            public static ButtonExtended btnUpdateShoppingCart = new ButtonExtended(By.ClassName("update-cart-button"), "btnUpdateShoppingCart");
            public static ButtonExtended btnContinueShopping = new ButtonExtended(By.ClassName("continue-shopping-button"), "btnContinueShopping");
            public static TextboxExtended txtEnterYourCoupon = new TextboxExtended(By.Name("discountcouponcode"), "txtEnterYourCoupon");
            public static ButtonExtended btnApplyCoupon = new ButtonExtended(By.Name("applydiscountcouponcode"), "btnApplyCoupon");
            public static TextboxExtended txtEnterGiftCardCode = new TextboxExtended(By.Name("giftcardcouponcode"), "txtEnterGiftCardCode");
            public static ButtonExtended btnAddGiftCardCode = new ButtonExtended(By.Name("applygiftcardcouponcode"), "btnAddGiftCardCode");
            public static DropDownExtended ddCountry = new DropDownExtended(By.Id("CountryId"), "ddCountry");
            public static DropDownExtended ddState = new DropDownExtended(By.Id("StateProvinceId"), "ddState");
            public static TextboxExtended txtZip = new TextboxExtended(By.Id("ZipPostalCode"), "txtZip");
            public static ButtonExtended btnEstimateShipping = new ButtonExtended(By.Name("estimateshipping"), "btnEstimateShipping");
            public static CheckboxExtended chkTermsOfService = new CheckboxExtended(By.Id("termsofservice"), "chkTermsOfService");
            public static ButtonExtended btnCheckout = new ButtonExtended(By.Id("checkout"), "btnCheckout");
        }

        public static class Checkout
        {
    
            public static class BillingAddress
            {
                public static TextboxExtended txtFirstName = new TextboxExtended(By.Id("BillingNewAddress_FirstName"), "txtFirstName");
                public static TextboxExtended txtLastName = new TextboxExtended(By.Id("BillingNewAddress_LastName"), "txtLastName");
                public static TextboxExtended txtEmail = new TextboxExtended(By.Id("BillingNewAddress_Email"), "txtEmail");
                public static TextboxExtended txtCompany = new TextboxExtended(By.Id("BillingNewAddress_Company"), "txtCompany");
                public static TextboxExtended txtCity = new TextboxExtended(By.Id("BillingNewAddress_City"), "txtCity");
                public static TextboxExtended txtAddress1 = new TextboxExtended(By.Id("BillingNewAddress_Address1"), "txtAddress1");
                public static TextboxExtended txtAddress2 = new TextboxExtended(By.Id("BillingNewAddress_Address2"), "txtAddress2");
                public static TextboxExtended txtZip = new TextboxExtended(By.Id("BillingNewAddress_ZipPostalCode"), "txtZip");
                public static TextboxExtended txtPhoneNumber = new TextboxExtended(By.Id("BillingNewAddress_PhoneNumber"), "txtPhoneNumber");
                public static TextboxExtended txtFaxNumber = new TextboxExtended(By.Id("BillingNewAddress_FaxNumber"), "txtFaxNumber");
                public static DropDownExtended ddCountry = new DropDownExtended(By.Id("BillingNewAddress_CountryId"), "ddCountry");
                public static DropDownExtended ddState = new DropDownExtended(By.Id("BillingNewAddress_StateProvinceId"), "ddState");
                public static ButtonExtended btnContinue = new ButtonExtended(By.CssSelector("#billing-buttons-container > input"), "btnContinue");

            }

            public static class ShippingAddress
            {
                public static DropDownExtended ddShippingAddress = new DropDownExtended(By.Id("shipping-address-select"), "ddShippingAddress");
                public static CheckboxExtended chkPickUpInStore = new CheckboxExtended(By.Id("PickUpInStore"), "PickUpInStore");
                public static ButtonExtended btnContinue = new ButtonExtended(By.CssSelector("#shipping-buttons-container > input"), "btnContinue");
                public static LinkExtended lnkBack = new LinkExtended(By.CssSelector("#shipping-buttons-container > p > a"), "lnkBack");
            }

            public static class ShippingMethod
            {
                public static ListExtended lstShippingMethod = new ListExtended(By.ClassName("method-list"),By.TagName("li"), "lstShippingMethod");
                public static ButtonExtended btnContinue = new ButtonExtended(By.CssSelector("#shipping-method-buttons-container > input"), "btnContinue");
                public static LinkExtended lnkBack = new LinkExtended(By.CssSelector("#shipping-method-buttons-container > p > a"), "lnkBack");
            }

            public static class PaymentMethod
            {
                public static ListExtended lstPaymentMethod = new ListExtended(By.CssSelector("#checkout-payment-method-load > div > div > ul"), By.TagName("li"), "lstPaymentMethod");
                public static ButtonExtended btnContinue = new ButtonExtended(By.CssSelector("#payment-method-buttons-container > input"), "btnContinue");
                public static LinkExtended lnkBack = new LinkExtended(By.CssSelector("#payment-method-buttons-container > p > a"), "lnkBack");
            }

            public static class PaymentInformation
            {
                public static WrapperExtended wrpPaymentInformation = new WrapperExtended(By.Id("checkout-payment-info-load"), "wrpPaymentInformation");
                public static ButtonExtended btnContinue = new ButtonExtended(By.CssSelector("#payment-info-buttons-container > input"), "btnContinue");
                public static LinkExtended lnkBack = new LinkExtended(By.CssSelector("#payment-info-buttons-container > p > a"), "lnkBack");
                public static LabelExtended lblInfo = new LabelExtended(By.CssSelector("#checkout-payment-info-load > div > div > div.info > table > tbody > tr > td > p"), "lblInfo");
            }

            public static class ConfirmOrder
            {
                public static ListExtended lstBillingInfo = new ListExtended(By.ClassName("billing-info"), By.TagName("li"), "lstBillingInfo");
                public static ListExtended lstShippingInfo = new ListExtended(By.ClassName("shipping-info"), By.TagName("li"), "lstShippingInfo");
                public static TableExtended tblCart = new TableExtended(By.ClassName("cart"), "tblCart");
                public static ButtonExtended btnConfirm = new ButtonExtended(By.ClassName("confirm-order-next-step-button"), "btnConfirm");
                public static LinkExtended lnkBack = new LinkExtended(By.CssSelector("#confirm-order-buttons-container > p > a"), "lnkBack");
            }

            public static class CheckoutCompleted
            {
                public static LabelExtended lblPageTitle = new LabelExtended(By.ClassName("page-title"), "lblPageTitle");
                public static WrapperExtended wrpOrderCompleted = new WrapperExtended(By.ClassName("order-completed"), "wrpOrderCompleted");
                public static LabelExtended lblTitle = new LabelExtended(By.ClassName("title"), "lblTitle");
                public static ButtonExtended btnContinue = new ButtonExtended(By.ClassName("order-completed-continue-button"), "btnContinue");
            }

        }

        public static class MyAccount
        {
            public static ListExtended lstMyAccount = new ListExtended(By.ClassName("list"), By.TagName("li"), "lstMyAccount");
            public static class CustomerInfo
            {
                public static PageExtended CustomerInfoPage = new PageExtended("customer/info", "CustomerInfoPage");
                public static WrapperExtended wrpCustomerInfo = new WrapperExtended(By.ClassName("customer-info-page"), "wrpCustomerInfo");
                public static RadioButtonExtended radiobtnMale = new RadioButtonExtended(By.Id("gender-male"), "radiobtnMale");
                public static RadioButtonExtended radiobtnFemale = new RadioButtonExtended(By.Id("gender-female"), "radiobtnFemale");
                public static TextboxExtended txtFirstName = new TextboxExtended(By.Id("FirstName"), "txtFirstName");
                public static TextboxExtended txtLastName = new TextboxExtended(By.Id("LastName"), "txtLastName");
                public static TextboxExtended txtEmail = new TextboxExtended(By.Id("Email"), "txtEmail");
                public static ButtonExtended btnSave = new ButtonExtended(By.Name("save-info-button"), "btnSave");

            }

            public static class ChangePassword
            {
                public static PageExtended ChangePasswordPage = new PageExtended("customer/changepassword", "ChangePasswordPage");
                public static WrapperExtended wrpChangePassword = new WrapperExtended(By.ClassName("change-password-page"), "wrpChangePassword");
                public static TextboxExtended txtOldPassword = new TextboxExtended(By.Id("OldPassword"), "txtOldPassword");
                public static TextboxExtended txtNewPassword = new TextboxExtended(By.Id("NewPassword"), "txtNewPassword");
                public static TextboxExtended txtConfirmNewPassword = new TextboxExtended(By.Id("ConfirmNewPassword"), "txtConfirmNewPassword");
                public static ButtonExtended btnChangePassword = new ButtonExtended(By.ClassName("change-password-button"), "btnChangePassword");
                public static LabelExtended lblResult = new LabelExtended(By.ClassName("result"), "lblResult");
            }
        }

    }
}

