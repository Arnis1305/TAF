using FluentAssertions;
using TechTalk.SpecFlow;
using PageObjects.Pages;

namespace Tests.BDD.Steps
{
    [Binding]
    public sealed class EbayMainPageSteps : BaseUIStep
    {
        private EbayMainPage ebayMainPage;

        public EbayMainPageSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
            ScenarioContext = scenarioContext;
        }

        [Given(@"I open official Ebay web site")]
        public void OpenOfficialEbayWebSite()
        {
            ebayMainPage = new EbayMainPage(Browser);
        }

        [Then(@"Ebay search field should be displayed")]
        public void SearchFieldShouldBeDisplayed()
        {
            ebayMainPage.SearchField.Displayed.Should().BeTrue();
        }
    }
}