using FluentAssertions;
using PageObjects.Pages;
using TechTalk.SpecFlow;

namespace Tests.BDD.Steps
{
    [Binding]
    public class EbayChangeLanguageSteps : BaseUIStep
    {
        private EbayMainPage ebayMainPage;

        protected EbayChangeLanguageSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
            ScenarioContext = scenarioContext;
        }

        [Given(@"I open ebay\.com")]
        public void OpenEbay()
        {
            ebayMainPage = new EbayMainPage(Browser);
        }

        [Given(@"I move the cursor over the language menu in the header")]
        public void MoveTheCursorOverTheLanguageMenuInTheHeader()
        {
            ebayMainPage.LanguageButton.MouseOver();
        }

        [When(@"I select English")]
        public void SelectEnglish()
        {
            ebayMainPage.SelectEnglishLanguageButton.Click();
        }

        [Then(@"the webpage should be shown in the English language")]
        public void TheWebpageShouldBeShownInTheEnglishLanguage()
        {
            ebayMainPage.LanguageButton.Text
                .Should()
                .Contain("English");
        }
    }
}