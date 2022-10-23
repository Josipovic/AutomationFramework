@UI @DemoWebShop
Feature: DemoWebShop

As a user I want to be able to create an account, log in, log out, change password and search for products on the DemoWebShop page

@TestCaseCode:TC001
Scenario: Visitor User Can Create An Account
	When I navigate to the DemoWebShop Page
	Then I should see Register link that is enabled
	And I should see Log In link that is enabled
	When I click on the Register link
	Then Register page should be displayed
	And I should see that the Register section is displayed on the Register Page
	And I should see Male radio button option that is enabled and not selected in the Register section
	And I should see Female radio button option that is enabled and not selected in the Register section
	And I should see First Name textbox that is enabled and empty in the Register Section
	And I should see Last Name textbox that is enabled and empty in the Register Section
	And I should see Email textbox that is enabled and empty in the Register Section
	And I should see Password textbox that is enabled and empty in the Register Section
	And I should see Confirm Password textbox that is enabled and empty in the Register Section
	And I should see Register button that is enabled
	When I enter my Personal Details on the Register section
	And I enter my Password on the Register section
	Then I should see that Register Section contains my personal Details
	And I should see that Register Section contains my password
	When I click on Register button
	Then I should see Result label that contains "Your registration completed" text
	And I should see Continue button that is enabled on the Register section
	When I click on the Continue button on the Register Page
	Then DemoWebShop page should be displayed
	And I should see My Account link that is enabled

@TestCaseCode:TC002
Scenario: Registered user can log out and log in
	Given I navigate to the DemoWebShop Page
	When I register a new user on the DemoWebShop Page
	Then I should see Log out link that is enabled
	When I click on the log out link
	Then Log out link should not be displayed
	And I should see Log In link that is enabled
	When I click on the Log in link
	Then Login page should be displayed
	And I should see Returning Customer section on the Login Page
	And I should see Email textbox that is enabled and empty in the Returning Customer section
	And I should see Password textbox that is enabled and empty in the Returning Customer section
	And I should see Remember me checkbox that is enabled and not checked in the Returning Customer section
	And I should see Forgot Password link that is enabled in the Returning Customer section
	And I should see Log In button that is enabled in the Returning Customer section
	When I enter my Email and Password on the Returning Customer section
	Then I should see that Returning Customer section contains my Email and Password
	When I click on Log In button in Returning Customer section
	Then I should see My Account link that is enabled
	And I should see Log out link that is enabled

@TestCaseCode:TC003 @PasswordChange
Scenario: Registered user can change the password and use it to log in
	Given I navigate to the DemoWebShop Page
	When I register a new user on the DemoWebShop Page
	Then I should see My Account link that is enabled
	When I click on My Account link
	Then Customer Info page should be displayed
	And I should see My Account list on the Customer Info page
	And I should see "Change password" link that is enabled in the My Account list
	And I should see Customer Info section on the Customer Info page
	And I should see Male radio button option that is enabled and not selected in the Customer Info section
	And I should see Female radio button option that is enabled and not selected in the Customer Info section
	And I should see First Name textbox that is enabled and contains my First Name in the Customer Info section
	And I should see Last Name textbox that is enabled and contains my Last Name in the Customer Info section
	And I should see Email textbox that is enabled and contains my Email in the Customer Info section
	And I should see Save button that is enabled in the Customer Info section
	When I click on the "Change password" link in the My Account list
	Then Change Password page should be displayed
	And I should see Change Password section on the Change Password page
	And I should see Old Password textbox that is enabled and empty in the Change Password section
	And I should see New Password textbox that is enabled and empty in the Change Password section
	And I should see Confirm Password textbox that is enabled and empty in the Change Password section
	And I should see Change Password button that is enabled in the Change Password section
	When I enter my Password details on the Change Password section
	Then I should see that Change Password section contains my Password detials
	When I click on the Change Password button in the Change Password section
	Then I should see Result label that contains "Password was changed" text in the Change Password section
	Then I should see Log out link that is enabled
	When I click on the log out link
	Then Log out link should not be displayed
	When I Login on the DemoWebShop Page
	Then I should see My Account link that is enabled
	And I should see Log out link that is enabled

@TestCaseCode:TC004
Scenario: Visitor user can search for products
	When I navigate to the DemoWebShop Page
	Then I should see Search textbox that is enabled
	And I should see Search button that is enabled
	And I should see Top Menu list
	And I should see "COMPUTERS" link that is enabled in the Top Menu list
	When I hover over "COMPUTERS" link in the Top Menu list
	Then I should see Sub List
	And I should see "Notebooks" link that is enabled in the Sub List
	When I click on "Notebooks" link in the Sub list
	Then Search Page that contains "notebooks" text is displayed
	And I should see Page Title that contains "Notebooks" text
	And I should see Product selectors section
	And I should see Product filters section
	And I should see Products List that is not empty
	And I should see "14.1-inch Laptop" product that is enabled in the Products List
	And I should see that "14.1-inch Laptop" product contains Add to cart button that is enabled
	When I click on the "14.1-inch Laptop" product in the Products List
	Then I should see Overview section
	And I should see Full Description section
	And I should see Product name label that contains "14.1-inch Laptop" text in the Oveview section
	And I should see Add to cart button that is enabled in the Overview section
	And I should see Email a friend button that is enabled in the Overview section
	And I should see Add to compare list button that is enabled in the Overview section
	And I should see Qty textbox that is enabled and contains "1" text in the Overview section
	When I enter "phone" text into Search textbox
	And I click on Search button
	Then Search Page that contains "phone" text is displayed
	And I should see Search Input section
	And I should see Product selectors section
	And I should see Search Results section
	And I should see Search Keyword textbox that is enabled and contains "phone" text
	And I should see Advanced Search checkbox that is enabled and not checked
	And I should see Products List that is not empty

@TestCaseCode:TC005
Scenario: Logged in user can search for products
	Given I navigate to the DemoWebShop Page
	When I register a new user on the DemoWebShop Page
	Then I should see My Account link that is enabled
	And I should see Log out link that is enabled
	And I should see Search textbox that is enabled
	And I should see Search button that is enabled
	And I should see Top Menu list
	And I should see "BOOKS" link that is enabled in the Top Menu list
	When I click on "BOOKS" link in the Top Menu list
	Then Search Page that contains "books" text is displayed
	And I should see Page Title that contains "Books" text
	And I should see Product selectors section
	And I should see Product filters section
	And I should see Products List that is not empty
	And I should see "Fiction" product that is enabled in the Products List
	And I should see that "Fiction" product contains Add to cart button that is enabled
	When I click on the "Fiction" product in the Products List
	Then I should see Overview section
	And I should see Full Description section
	And I should see Product name label that contains "Fiction" text in the Oveview section
	And I should see Add to cart button that is enabled in the Overview section
	And I should see Email a friend button that is enabled in the Overview section
	And I should see Add to compare list button that is enabled in the Overview section
	And I should see Qty textbox that is enabled and contains "1" text in the Overview section
	When I enter "shirt" text into Search textbox
	And I click on Search button
	Then Search Page that contains "shirt" text is displayed
	And I should see Search Input section
	And I should see Product selectors section
	And I should see Search Results section
	And I should see Search Keyword textbox that is enabled and contains "shirt" text
	And I should see Advanced Search checkbox that is enabled and not checked
	And I should see Products List that is not empty

@TestCaseCode:TC006
Scenario: Logged in user can add product to cart and complete order
	Given I navigate to the DemoWebShop Page
	When I register a new user on the DemoWebShop Page
	Then I should see My Account link that is enabled
	And I should see Log out link that is enabled
	And I should see Shopping cart link that is enabled and contains "0" text
	And I should see Top Menu list
	When I search for "Computing and Internet" product under "Books" menu
	When I click on the Add to cart button in the Overview section
	Then I should see Shopping cart link that is enabled and contains "1" text
	When I click on the Shopping cart link
	Then I should see Cart table that is not empty
	And I should see that Cart table contains "Remove", "Product(s)", "Price", "Qty." and "Total" columns
	And I should see that "Product(s)" column contains "Computing and Internet" text in the Cart table
	And I should see Update Shopping Cart button that is enabled
	And I should see Continue Shopping button that is enabled
	And I should see Enter your coupon here textbox that is enabled and empty
	And I should see Apply coupon button that is enabled
	And I should see Add gift card textbox that is enabled and empty
	And I should see Add gift card button that is enabled
	And I should see Select country dropdown that is enabled with "Select country" option selected
	And I should see State/Province dropdown that is enabled with "Other (Non US)" option selected
	And I should see Zip/Postal code textbox that is enabled and empty
	And I should see Estimate shipping button that is enabled
	And I should see Terms Of Service checkbox that is enabled and not checked
	And I should see Checkout button that is enabled
	When I click on Terms Of Service checkbox
	And I click on the Checkout button
	Then I should see Billing Adress details on the Checkout page
	And I should see Continue button that is enabled in the Billing Address section
	When I enter my Billing details
	Then I should see that Checkout page contains my Billing details
	When I click on the Continue button on the Billing Address section
	Then I should see Shipping Address dropdown that is enabled and contains my address details
	And I should see In Store Pickup checkbox that is enabled and not checked
	And I should see Back link that is enabled in the Shipping address section
	And I should see Continue button that is enabled in the Shipping Address section
	When I click on the Continue button in the Shipping Address section
	Then I should see Shipping Method list
	And I should see "Ground" radio button that is enabled in the Shipping method list
	And I should see "Next Day Air" radio button that is enabled in the Shipping method list
	And I should see "2nd Day Air" radio button that is enabled in the Shipping method list
	And I should see Continue button that is enabled in the Shipping method section
	And I should see Back link that is enabled in the Shipping Method section
	When I click on the "2nd Day Air" radio button in the Shipping method list
	And I click on the Continue button in the Shipping method section
	Then I should see Payment Method list
	And I should see "Cash On Delivery (COD)" radio button that is enabled in the Payment Method list
	And I should see "Check / Money Order" radio button that is enabled in the Payment Method list
	And I should see "Credit Card" radio button that is enabled in the Payment Method list
	And I should see "Purchase Order" radio button that is enabled in the Payment Method list
	And I should see Back link that is enabled in the Payment Method section
	And I should see Continue button that is enabled in the Payment Method section
	When I click on the "Cash On Delivery (COD)" radio button in the Payment Method list
	And I click on the Continue button in the Payment Method section
	Then I should see Payment Information section
	And I should see Back link that is enabled in the Payment Information section
	And I should see Continue button that is enabled in the Payment Information section
	And I should see Info label that contains "You will pay by COD" text in the Payment Information section
	When I click on the Continue button in the Payment Information section
	Then I should see Billing Info list that is not empty
	And I should see Shipping Info list that is not empty
	And I should see Cart table that is not empty on the CheckoutPage
	And I should see Confirm button that is enabled
	When I click on the Confirm button
	Then I should see Page title label that contains "Thank you" text
	And I should see Order completed section
	And I should see Title label that contains "Your order has been successfully processed!" text
	And I should see Continue button that is enabled in the Order completed section

	
	
	
