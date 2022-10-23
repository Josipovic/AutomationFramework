using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TestingProject.TestBook.Specflow.Glue
{
    [Binding]
    public class DemoWebShop_Search_Steps
    {
        [Then(@"I should see Search textbox that is enabled")]
        public void ThenIShouldSeeSearchTextboxThatIsEnabled()
        {
            DemoShopMap.Main.txtSearch.VerifyDisplayed();
            DemoShopMap.Main.txtSearch.VerifyEnabled();
        }

        [Then(@"I should see Search button that is enabled")]
        public void ThenIShouldSeeSearchButtonThatIsEnabled()
        {
            DemoShopMap.Main.btnSearch.VerifyDisplayed();
            DemoShopMap.Main.btnSearch.VerifyEnabled();
        }

        [Then(@"I should see Top Menu list")]
        public void ThenIShouldSeeTopMenuList()
        {
            DemoShopMap.Main.lstTopMenu.VerifyDisplayed();
        }

        [Then(@"I should see ""([^""]*)"" link that is enabled in the Top Menu list")]
        public void ThenIShouldSeeLinkThatIsEnabledInTheTopMenuList(string Text)
        {
            DemoShopMap.Main.lstTopMenu.VerifyElementInListDisplayed(Text);
            DemoShopMap.Main.lstTopMenu.VerifyElementInListEnabled(Text);
        }

        [When(@"I hover over ""([^""]*)"" link in the Top Menu list")]
        public void WhenIHoverOverLinkInTheTopMenuList(string Text)
        {
            DemoShopMap.Main.lstTopMenu.MoveToElementInList(Text);
        }

        [Then(@"I should see Sub List")]
        public void ThenIShouldSeeSubList()
        {
            DemoShopMap.Main.lstTopMenu.GetSubList(By.ClassName("sublist"), By.TagName("li"), "lstSubList").VerifyDisplayed();
        }

        [Then(@"I should see ""([^""]*)"" link that is enabled in the Sub List")]
        public void ThenIShouldSeeLinkThatIsEnabledInTheSubList(string Text)
        {
            DemoShopMap.Main.lstTopMenu.GetSubList(By.ClassName("sublist"), By.TagName("li"), "lstSubList").VerifyElementInListDisplayed(Text);
            DemoShopMap.Main.lstTopMenu.GetSubList(By.ClassName("sublist"), By.TagName("li"), "lstSubList").VerifyElementInListEnabled(Text);
        }

        [When(@"I click on ""([^""]*)"" link in the Sub list")]
        public void WhenIClickOnLinkInTheSubList(string Text)
        {
            DemoShopMap.Main.lstTopMenu.GetSubList(By.ClassName("sublist"), By.TagName("li"), "lstSubList").ClickOnElementInList(Text);
        }

        [Then(@"I should see Products List that is not empty")]
        public void ThenIShouldSeeProductsListThatIsNotEmpty()
        {
            DemoShopMap.Search.lstProducts.VerifyDisplayed();
            DemoShopMap.Search.lstProducts.VerifyEmpty(false);
        }

        [When(@"I enter ""([^""]*)"" text into Search textbox")]
        public void WhenIEnterTextIntoSearchTextbox(string Text)
        {
            DemoShopMap.Main.txtSearch.SetText(Text);
        }

        [When(@"I click on Search button")]
        public void WhenIClickOnSearchButton()
        {
            DemoShopMap.Main.btnSearch.Click();
        }

        [Then(@"I should see Search Input section")]
        public void ThenIShouldSeeSearchInputSection()
        {
            DemoShopMap.Search.wrpSearchInput.VerifyDisplayed();
        }

        [Then(@"I should see Search Results section")]
        public void ThenIShouldSeeSearchResultsSection()
        {
            DemoShopMap.Search.wrpSearchResults.VerifyDisplayed();
        }

        [Then(@"I should see Search Keyword textbox that is enabled and contains ""([^""]*)"" text")]
        public void ThenIShouldSeeSearchKeywordTextboxThatIsEnabledAndContainsText(string Text)
        {
            DemoShopMap.Search.txtSearchKeyword.VerifyDisplayed();
            DemoShopMap.Search.txtSearchKeyword.VerifyEnabled();
            DemoShopMap.Search.txtSearchKeyword.VerifyText(Text);
        }

        [Then(@"I should see Advanced Search checkbox that is enabled and not checked")]
        public void ThenIShouldSeeAdvancedSearchCheckboxThatIsEnabledAndNotChecked()
        {
            DemoShopMap.Search.chkAdvancedSearch.VerifyDisplayed();
            DemoShopMap.Search.chkAdvancedSearch.VerifyEnabled();
            DemoShopMap.Search.chkAdvancedSearch.VerifyChecked(false);
        }

        [Then(@"I should see Page Title that contains ""([^""]*)"" text")]
        public void ThenIShouldSeePageTitleThatContainsText(string Text)
        {
            DemoShopMap.Search.lblPageTitle.VerifyTextContains(Text);
        }

        [Then(@"I should see Product selectors section")]
        public void ThenIShouldSeeProductSelectorsSection()
        {
            DemoShopMap.Search.wrpProductSelectors.VerifyDisplayed();
        }

        [Then(@"I should see Product filters section")]
        public void ThenIShouldSeeProductFiltersSection()
        {
            DemoShopMap.Search.wrpProductFilters.VerifyDisplayed();
        }

        [Then(@"Search Page that contains ""([^""]*)"" text is displayed")]
        public void ThenSearchPageThatContainsTextIsDisplayed(string Text)
        {
            DemoShopMap.Search.SearchPage(Text).VerifyContains();
        }

        [When(@"I click on ""([^""]*)"" link in the Top Menu list")]
        public void WhenIClickOnLinkInTheTopMenuList(string Text)
        {
            DemoShopMap.Main.lstTopMenu.ClickOnElementInList(Text);
        }

        [When(@"I search for ""([^""]*)"" product under ""([^""]*)"" menu")]
        public void WhenISearchForProductUnderMenu(string Product, string Menu)
        {
            ThenIShouldSeeLinkThatIsEnabledInTheTopMenuList(Menu.ToUpper());
            WhenIClickOnLinkInTheTopMenuList(Menu.ToUpper());
            ThenSearchPageThatContainsTextIsDisplayed(Menu.ToLower());
            ThenIShouldSeePageTitleThatContainsText(Menu);
            ThenIShouldSeeProductSelectorsSection();
            ThenIShouldSeeProductFiltersSection();
            ThenIShouldSeeProductsListThatIsNotEmpty();
            ThenIShouldSeeProductThatIsEnabledInTheProductsList(Product);
            ThenIShouldSeeThatProductContainsAddToCartButtonThatIsEnabled(Product);
            WhenIClickOnTheProductInTheProductsList(Product);
            ThenIShouldSeeOverviewSection();
            ThenIShouldSeeFullDescriptionSection();
            ThenIShouldSeeProductNameLabelThatContainsTextInTheOveviewSection(Product);
            DemoWebShop_Order_Steps.ThenIShouldSeeAddToCartButtonThatIsEnabledInTheOverviewSection();
            DemoWebShop_Order_Steps.ThenIShouldSeeEmailAFriendButtonThatIsEnabledInTheOverviewSection();
            DemoWebShop_Order_Steps.ThenIShouldSeeAddToCompareListButtonThatIsEnabledInTheOverviewSection();
            DemoWebShop_Order_Steps.ThenIShouldSeeQtyTextboxThatIsEnabledAndContainsTextInTheOverviewSection("1");
        }

        [Then(@"I should see ""([^""]*)"" product that is enabled in the Products List")]
        public void ThenIShouldSeeProductThatIsEnabledInTheProductsList(string Text)
        {
            DemoShopMap.Search.lstProducts.VerifyElementInListDisplayed(Text);
            DemoShopMap.Search.lstProducts.VerifyElementInListEnabled(Text);
        }

        [Then(@"I should see that ""([^""]*)"" product contains Add to cart button that is enabled")]
        public void ThenIShouldSeeThatProductContainsAddToCartButtonThatIsEnabled(string Product)
        {
            DemoShopMap.Search.lstProducts.VerifyAddToCartButtonDisplayedAndEnabled(Product);
        }

        [When(@"I click on the ""([^""]*)"" product in the Products List")]
        public void WhenIClickOnTheProductInTheProductsList(string Product)
        {
            DemoShopMap.Search.lstProducts.ClickOnElementInList(Product);
        }

        [Then(@"I should see Overview section")]
        public void ThenIShouldSeeOverviewSection()
        {
            DemoShopMap.Product.wrpOverview.VerifyDisplayed();
        }

        [Then(@"I should see Full Description section")]
        public void ThenIShouldSeeFullDescriptionSection()
        {
            DemoShopMap.Product.wrpFullDescription.VerifyDisplayed();
        }

        [Then(@"I should see Product name label that contains ""([^""]*)"" text in the Oveview section")]
        public void ThenIShouldSeeProductNameLabelThatContainsTextInTheOveviewSection(string Text)
        {
            DemoShopMap.Product.lblProductName.VerifyTextContains(Text);
        }
    }
}
