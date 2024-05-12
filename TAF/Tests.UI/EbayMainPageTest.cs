using FluentAssertions;
using PageObjects.Pages;

namespace Tests.UI
{
    [TestFixture]
    public class EbayMainPageTest : BaseUITest
    {
        [Test]
        public void CheckEbayMainPageToBeOpened()
        {
            EbayMainPage ebayMainPage = new EbayMainPage(Browser);

            ebayMainPage.SearchField.Displayed.Should().BeTrue();
        }

        [TestCase("Fashion")]
        public void CheckFashionPageToBeOpened(string pageHeader)
        {
            EbayMainPage ebayMainPage = new EbayMainPage(Browser);

            ebayMainPage.OpenFashionPage()
                .FashionHeader.Text
                .Should()
                .Contain(pageHeader);
            ebayMainPage.SearchField.Displayed.Should().BeTrue();
        }

        [Test]
        public void CheckEbayLogoExist()
        {
            EbayMainPage ebayMainPage = new EbayMainPage(Browser);

            ebayMainPage.EbayLogo.Displayed.Should().BeTrue();
        }

        [TestCase("iphone 12 mini 128gb")]
        public void CheckIphoneSearched(string searchedText)
        {
            EbayMainPage ebayMainPage = new EbayMainPage(Browser);

            ebayMainPage.SearchFor(searchedText)
                .SearchedHeader.Text
                .Should().Contain(searchedText);
        }
    }
}