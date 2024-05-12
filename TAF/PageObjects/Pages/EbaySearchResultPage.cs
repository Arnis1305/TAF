using Core.UI.WebDriverWrapper.Interfaces;
using Core.UI.WebElementWrapper;
using PageObjects.Locators;

namespace PageObjects.Pages
{
    public class EbaySearchResultPage : BasePage
    {
        public EbaySearchResultPage(IBrowser driver) : base(driver)
        {
            this.Driver = driver;
        }

        public IElement SearchedHeader => Driver.FindElement(EbaySearchResultPageBy.SearchedHeader);
    }
}