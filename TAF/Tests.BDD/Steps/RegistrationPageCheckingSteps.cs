using FluentAssertions;
using PageObjects.Pages;
using TechTalk.SpecFlow;

namespace Tests.BDD.Steps
{
    [Binding]
    public sealed class RegistrationPageCheckingSteps : BaseUIStep
    {
        private readonly ScenarioContext scenarioContext;
        private EbayMainPage ebayMainPage;
        private RegistrationPage registrationPage;
        public RegistrationPageCheckingSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
            ScenarioContext = scenarioContext;
        }

        [When(@"I click the Registration item from the main page")]
        public void WhenIClickTheRegistrationItemFromTheMainPage()
        {
            ebayMainPage = new EbayMainPage(Browser);
            ebayMainPage.OpenRegistrationPage();
        }

        [Then(@"The Registration page should be opened")]
        public void ThenTheRegistrationPageShouldBeOpened()
        {
            registrationPage = new RegistrationPage(Browser);
            registrationPage.RegistrationHeader.Text.Should().NotBeNull();
        }
    }
}