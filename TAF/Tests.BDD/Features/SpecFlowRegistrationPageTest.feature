Feature: SpecFlowRegistrationPageTest
	In order to easily find needed product
	As a eBay user
	I want to be able to navigate to pages through main page

@smoke
Scenario: Clicking Registration option from the main menu should open Registration page
	Given I open eBay web site
	When I click the Registration item from the main page
	Then The Registration page should be opened