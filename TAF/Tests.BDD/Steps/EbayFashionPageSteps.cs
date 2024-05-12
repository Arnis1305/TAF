using FluentAssertions;
using TechTalk.SpecFlow;
using PageObjects.Pages;

namespace Tests.BDD.Steps
{
    [Binding]
    public sealed class EbayFashionPageSteps : BaseUIStep
    {
        private EbayMainPage ebayMainPage;
        private FashionPage fashionPage;

        public EbayFashionPageSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
            ScenarioContext = scenarioContext;
        }

        [Given(@"I open Ebay web site")]
        public void OpenOfficialEbayWebSite()
        {
            ebayMainPage = new EbayMainPage(Browser);
        }

        [When(@"I click Fashion button on menu")]
        public void WhenIClickTheFashionButtonOnMenu()
        {
            ebayMainPage.OpenFashionPage();
        }

        [Then(@"Page Fashion should be opened")]
        public void ThenFashionPageShouldBeOpened()
        {
            fashionPage = new FashionPage(Browser);
            fashionPage.FashionHeader.Displayed.Should().BeTrue();
        }
    }
}