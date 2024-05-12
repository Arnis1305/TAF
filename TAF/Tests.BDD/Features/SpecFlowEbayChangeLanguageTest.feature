Feature: SpecFlowEbayChangeLanguageTest
  In order to use Ebay
  As an Ebay user
  I want to change language
  
@smoke 
Scenario: Clicking the language menu should change page language
  Given I open ebay.com
  And I move the cursor over the language menu in the header
  When I select English
  Then the webpage should be shown in the English language