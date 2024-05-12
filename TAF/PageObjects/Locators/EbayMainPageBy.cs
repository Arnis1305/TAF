using OpenQA.Selenium;

namespace PageObjects.Locators
{
    public class EbayMainPageBy
    {
        public static By SearchField = By.XPath("//input[@type='text']");
        public static By FashionButton = By.XPath("//li[@class = 'hl-cat-nav__js-tab'][2]");
        public static By EbayLogo = By.XPath("//*[@id='gh-l-h1']");
        public static By SearchButton = By.XPath("//input[@id='gh-btn']");
        public static By LanguageButton = By.XPath("id='gh-eb-Geo-a-default'");
        public static By ChooseEnglishLanguageButton = By.XPath("id='gh-eb-Geo-a-en'");
        public static By MainMenu = By.XPath("//li[@data-currenttabindex = '1']/a[text()='Fashion']");
        public static By Registration = By.XPath("//span[@id='gh-ug-flex']/a");
    }
}