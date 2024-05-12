using Core;
using Core.AppSettings;
using Core.UI.WebDriverWrapper.Interfaces;
using Core.UI.BrowserBuilder;
using TechTalk.SpecFlow;

namespace Tests.BDD.Steps
{
    [Binding]
    public class BaseUIStep : BaseTest
    {
        protected static IBrowser Browser;

        protected ScenarioContext ScenarioContext;

        protected BaseUIStep(ScenarioContext scenarioContext)
        {
            ScenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            Browser = BrowserSingleton.GetBrowser(ApplicationConfig.BrowserName);
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl(ApplicationConfig.URL);
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            BrowserSingleton.ReleaseInstance();
            Browser.Close();
            Browser.Quit();
        }
    }
}