using OpenQA.Selenium;

namespace PageObjects.Locators
{
    public class EbaySearchResultPageBy
    {
        public static By SearchedHeader = By.XPath("//h1/span[@class='BOLD'][2]");
    }
}