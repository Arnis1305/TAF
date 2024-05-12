Feature: SpecFlowEbaySearchTest
	In order to search products
	As an Ebay user
	I want to search products using search field

@smoke
Scenario Outline: Writing product name in search field should open product page
	Given I open official Ebay website 
	When I enter '<searchedText>' and click search button
	Then Page with '<searchedText>' should be opened

	Examples: 
	| searchedText		 |
	|iphone 12 mini 128gb|