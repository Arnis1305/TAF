using FluentAssertions;
using TechTalk.SpecFlow;
using PageObjects.Pages;

namespace Tests.BDD.Steps
{
    [Binding]
    public sealed class EbaySearchPageSteps : BaseUIStep
    {
        private EbayMainPage ebayMainPage;
        private EbaySearchResultPage ebaySearchResultPage;

        public EbaySearchPageSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
            ScenarioContext = scenarioContext;
        }

        [Given(@"I open official Ebay website")]
        public void OpenOfficialEbayWebsite()
        {
            ebayMainPage = new EbayMainPage(Browser);
        }

        [When(@"I enter '(.*)' and click search button")]
        public void EnterProductNameAndClickSearchButton(string searchedText)
        {
            ebayMainPage.SearchFor(searchedText);
        }

        [Then(@"Page with '(.*)' should be opened")]
        public void PageWithProductNameShouldBeOpened(string searchedText)
        {
            ebaySearchResultPage = new EbaySearchResultPage(Browser);

            ebaySearchResultPage.SearchedHeader.Text.Should().Contain(searchedText);
        }
    }
}