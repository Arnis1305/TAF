using Core.UI.WebDriverWrapper.Interfaces;
using Core.UI.WebElementWrapper;
using PageObjects.Locators;

namespace PageObjects.Pages
{
    public class EbayMainPage : BasePage
    {
        public EbayMainPage(IBrowser driver) : base(driver)
        {
            this.Driver = driver;
        }

        public IElement SearchField => Driver.FindElement(EbayMainPageBy.SearchField);
        public IElement EbayLogo => Driver.FindElement(EbayMainPageBy.EbayLogo);
        public IElement SearchButton => Driver.FindElement(EbayMainPageBy.SearchButton);
        public IElement FashionButton => Driver.FindElement(EbayMainPageBy.FashionButton);
        public IElement LanguageButton => Driver.FindElement(EbayMainPageBy.LanguageButton);
        public IElement SelectEnglishLanguageButton => Driver.FindElement(EbayMainPageBy.ChooseEnglishLanguageButton);
        public IElement MainMenuItem => Driver.FindElement(EbayMainPageBy.MainMenu);
        public IElement Registration => Driver.FindElement(EbayMainPageBy.Registration);

        public EbaySearchResultPage SearchFor(string searchingText)
        {
            SearchField.SendKeys(searchingText);
            SearchButton.Click();
            return new EbaySearchResultPage(Driver);
        }

        public FashionPage OpenFashionPage()
        {
            FashionButton.Click();
            return new FashionPage(Driver);
        }

        public RegistrationPage OpenRegistrationPage()
        {
            Registration.Click();
            return new RegistrationPage(Driver);
        }
    }
}