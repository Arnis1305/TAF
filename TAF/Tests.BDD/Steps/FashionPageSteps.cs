using FluentAssertions;
using PageObjects.Pages;
using TechTalk.SpecFlow;

namespace Tests.BDD.Steps
{
    [Binding]
    public class FashionPageSteps : BaseUIStep
    {
        private EbayMainPage ebayMainPage;
        private FashionPage fashionPage;

        protected FashionPageSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
            ScenarioContext = scenarioContext;
        }

        [Given(@"I open ebay\.com")]
        public void OpenEbay()
        {
            ebayMainPage = new EbayMainPage(Browser);
        }

        [When(@"I click fashion button in the menu")]
        public void ClickFashionButtonInTheMenu()
        {
            fashionPage = ebayMainPage.OpenFashionPage();
        }

        [Then(@"Ebay fashion page should be displayed")]
        public void EbayFashionPageShouldBeDisplayed()
        {
            fashionPage.FashionHeader.Text
                .Should()
                .Contain("Fashion");
        }
    }
}