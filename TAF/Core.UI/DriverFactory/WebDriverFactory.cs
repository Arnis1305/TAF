using Core.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace Core.UI.DriverFactory
{
    public class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(BrowserName browser)
        {
            IWebDriver driver;

            switch (browser)
            {
                case BrowserName.Chrome:
                    var chromeOption = new ChromeOptions();
                    chromeOption.AddArgument("headless");
                    driver = new ChromeDriver(chromeOption);
                    break;
                case BrowserName.FireFox:
                    var fireFoxOptions = new FirefoxOptions();
                    fireFoxOptions.AddArgument("--headless");
                    driver = new FirefoxDriver(fireFoxOptions);
                    break;
                case BrowserName.Opera:
                    var chromeOptionOpera = new ChromeOptions();
                    chromeOptionOpera.AddArgument("headless");
                    driver = new ChromeDriver(chromeOptionOpera);
                    //driver = new OperaDriver();
                    break;
                case BrowserName.Edge:
                    var edgeOptions = new EdgeOptions();
                    //edgeOptions.UseChromium = true;
                    edgeOptions.AddArgument("headless");
                    driver = new EdgeDriver(edgeOptions);
                    break;                
                default:
                    throw new PlatformNotSupportedException($"{browser} is not currently supported.");
            }

            return driver;
        }
    }
}