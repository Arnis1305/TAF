using OpenQA.Selenium;

namespace PageObjects.Locators
{
    public class RegistrationPageBy
    {
        public static By RegistrationHeader = By.XPath("//div[@data-page='emailReg']/h1[@class='giant-text-2 txt-center title']");
    }
}