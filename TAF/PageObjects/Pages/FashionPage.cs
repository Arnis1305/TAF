using Core.UI.WebDriverWrapper.Interfaces;
using Core.UI.WebElementWrapper;
using PageObjects.Locators;

namespace PageObjects.Pages
{
    public class FashionPage : BasePage
    {
        public FashionPage(IBrowser driver) : base(driver)
        {
            this.Driver = driver;
        }

        public IElement FashionHeader => Driver.FindElement(FashionPageBy.FashionHeader);
        public IElement ShoesPage => Driver.FindElement(FashionPageBy.ShoesItem);

        public ShoesPage OpenShoesPage()
        {
            ShoesPage.Click();
            return new ShoesPage(Driver);
        }
    }
}