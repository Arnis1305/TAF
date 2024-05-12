using OpenQA.Selenium;

namespace PageObjects.Locators
{
    public class FashionPageBy
    {
        public static By FashionHeader = By.XPath("//div[@class = 'content']/h2");
        public static By ShoesItem = By.XPath("//section[@class='b-module b-list b-categorynavigations b-display--landscape']//a[text()='Shoes']");

    }
}