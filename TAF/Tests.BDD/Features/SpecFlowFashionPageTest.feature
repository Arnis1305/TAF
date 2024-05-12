Feature: SpecFlowFashionPageTest
  In order to use Ebay
  As an Ebay user
  I want to be able to open Ebay fashion page

  @smoke
  Scenario: Ebay fashion page should be opened
    Given I open ebay.com
    When I click fashion button in the menu
    Then Ebay fashion page should be displayed