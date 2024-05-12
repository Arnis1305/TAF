Feature: SpecFlowEbayMainPageTest
	In order to use Ebay
	As an Ebay user
	I want to be able to open Ebay main page

@smoke
Scenario: Ebay Url should open Ebay main page
	Given I open official Ebay web site
	Then Ebay search field should be displayed