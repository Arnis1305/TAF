Feature: SpecFlowEbayFashionPageTest 
	In order to use Ebay
	As an Ebay user
	I want to be able to open Ebay Fashion page

@smoke
Scenario: Fashion button on menu should open Fashion page
	Given I open Ebay web site
	When I click Fashion button on menu 
	Then Page Fashion should be opened