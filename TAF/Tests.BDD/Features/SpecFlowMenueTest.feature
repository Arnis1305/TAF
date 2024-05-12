Feature: SpecFlowMenueTest
	In order to easily find needed product
	As a eBay user
	I want to be able to navigate to pages through main menu

@smoke
Scenario: Clicking Footwear option from the main menu should open Footwear page
	Given I open eBay web site
	When I click the Fashion menu item from the menu
	Then page 'Fashion' page should be opened
	And  I click Shoes option from main menu
	Then page with Shoes should be opened