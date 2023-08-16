using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Basics;

public class SeleniumTests
{
    private IWebDriver driver { get; set; }
    private string epamUrl = "https://www.epam.com/";

    [SetUp]
    public void SetupBrowser()
    {
        var options = new ChromeOptions();
        options.BinaryLocation = "/Applications/Google Chrome.app/Contents/MacOS/Google Chrome";
        driver = new ChromeDriver(options);
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }

    [Test]
    public void CheckThatCorrectLandingPageDisplayed()
    {
        Assert.That(driver.Url, Is.EqualTo(epamUrl), "Landing page is not displayed correctly");
    }

    [Test]
    public void CheckThatGoBackToPreviousPageWorks()
    {
        var howUrl = "https://www.epam.com/how-we-do-it";

        driver.Navigate().GoToUrl(howUrl);
        driver.Navigate().GoToUrl(epamUrl);
        driver.Navigate().Refresh();
        driver.Navigate().Back();
        Assert.That(driver.Url, Is.EqualTo(howUrl), "Navigation back works incorrectly");
    }

    [Test]
    public void CreateAndFindSimpleLocators()
    {
        driver.FindElement(By.XPath("//*[@class='header-search__button header__icon']"));
        driver.FindElement(By.XPath("//*[@id ='onetrust-consent-sdk']"));
        driver.FindElement(By.XPath(
            "//*[@class='mobile-location-selector__link active']//ancestor::*[@href='https://www.epam.com']"));
        driver.FindElement(By.XPath("//*[@name='vendor-search-handler']"));
        driver.FindElement(By.XPath("//nav[@class='hamburger-menu__dropdown']"));
    }

    [Test]
    public void FindContactUsButton()
    {
        driver.FindElement(
            By.XPath("//*[@class='hamburger-menu__item cta-button-menu-item']//span[@class='cta-button__text']"));
    }
}