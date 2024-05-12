using Core.UI.WebDriverWrapper.Interfaces;
using Core.UI.WebElementWrapper;
using PageObjects.Locators;

namespace PageObjects.Pages
{
    public class RegistrationPage : BasePage
    {
        public RegistrationPage(IBrowser driver) : base(driver)
        {
            this.Driver = driver;
        }

        public IElement RegistrationHeader => Driver.FindElement(RegistrationPageBy.RegistrationHeader);
    }
}