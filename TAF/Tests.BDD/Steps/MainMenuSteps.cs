using FluentAssertions;
using PageObjects.Pages;
using TechTalk.SpecFlow;


namespace Tests.BDD.Steps
{
    [Binding]
    public sealed class MainMenuSteps : BaseUIStep
    {
        private EbayMainPage ebayMainPage;
        private FashionPage fashionPage;
        private ShoesPage shoesPage;

        public MainMenuSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
            ScenarioContext = scenarioContext;
        }
        [Given(@"I open eBay web site")]
        public void IOpenEBayWebSite()
        {

        }

        [When(@"I click the Fashion menu item from the menu")]
        public void IClickTheFashionMenuItemFromTheMenu()
        {
            ebayMainPage = new EbayMainPage(Browser);
            ebayMainPage.OpenFashionPage();
        }

        [Then(@"page '(.*)' page should be opened")]
        public void PageFashionPageShouldBeOpened(string title)
        {
            fashionPage = new FashionPage(Browser);
            fashionPage.FashionHeader.Should().Equals(title);
        }

        [Then(@"I click Shoes option from main menu")]
        public void IClickShoesOptionFromMainMenu()
        {
            fashionPage.OpenShoesPage();
        }

        [Then(@"page with Shoes should be opened")]
        public void PageWithShouldBeOpened()
        {
            shoesPage = new ShoesPage(Browser);
            shoesPage.ShoesHeader.Text.Should().NotBeEmpty();
        }
    }
}