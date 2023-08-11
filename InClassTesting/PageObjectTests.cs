using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace InClassTesting;

public class PageObjectsTests
{
    private IWebDriver driver;
    
    [SetUp]
    public void BrowserSetup()
    {
        var options = new ChromeOptions();
        options.BinaryLocation = "/Applications/Google Chrome.app/Contents/MacOS/Google Chrome";
        driver = new ChromeDriver(options);
        var epamUrl = "https://www.epam.com/";
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
    }

    [Test]
    public void SearchResultsPageIsOpenedTest()
    {
        EpamLandingPage landingPage = new EpamLandingPage(driver);
        landingPage.SearchButton.Click();
        landingPage.EpamSearchBlock.SearchInput.SendKeys("Test automation");
        landingPage.EpamSearchBlock.FindButton.Click();
        EpamSearchResultsPage searchPage = new EpamSearchResultsPage(driver);
        var searchResultCount = searchPage.SearchResults.Count;
        Assert.That(searchResultCount,Is.GreaterThan(0));
    }
    
    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}