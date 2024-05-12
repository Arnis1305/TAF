using Core.UI.WebDriverWrapper.Interfaces;
using Core.UI.WebElementWrapper;
using PageObjects.Locators;

namespace PageObjects.Pages
{
    public class ShoesPage : BasePage
    {
        public ShoesPage(IBrowser driver) : base(driver)
        {
            this.Driver = driver;
        }

        public IElement ShoesHeader => Driver.FindElement(ShoesPageBy.ShoesHeader);
    }
}