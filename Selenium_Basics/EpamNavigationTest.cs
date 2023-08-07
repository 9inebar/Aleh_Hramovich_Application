using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Selenium_Basics;

public class SeleniumTests
{
    private IWebDriver driver { get; set; }
    protected string epamUrl = "https://www.epam.com/";

    [SetUp]
    public void SetupBrowser()
    {
        var options = new ChromeOptions();
        options.BinaryLocation = "/Applications/Google Chrome.app/Contents/MacOS/Google Chrome";
        driver = new ChromeDriver(options);
    }
    
    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }

    [Test]
    public void CheckThatCorrectLandingPageDisplayed()
    {
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
        Assert.That(driver.Url,Is.EqualTo(epamUrl), "Landing page is not displayed correctly");
    }
    
    [Test]
    public void CheckNavigationToPreviousPage()
    {
        var howUrl = "https://www.epam.com/how-we-do-it";
        var ourWorkUrl = "https://www.epam.com/our-work";
        
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(howUrl);
        driver.Navigate().GoToUrl(ourWorkUrl);
        driver.Navigate().Refresh();
        driver.Navigate().Back();
        Assert.That(driver.Url,Is.EqualTo(howUrl), "Navigation back works incorrectly");
    }
    
    [Test]
    public void CreateAndFindSimpleLocators()
    {
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);

        driver.FindElement(By.XPath("//*[@class='header-search__button header__icon']"));
        driver.FindElement(By.XPath("//*[@id ='onetrust-consent-sdk']"));
        driver.FindElement(By.XPath("//*[@class='mobile-location-selector__link active']//ancestor::*[@href='https://www.epam.com']"));
        driver.FindElement(By.XPath("//*[@name='vendor-search-handler']"));
        driver.FindElement(By.XPath("//nav[@class='hamburger-menu__dropdown']"));
    }
    
    [Test]
    public void FindContactUsButton()
    {
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
        driver.FindElement(By.XPath("//*[@class='hamburger-menu__item cta-button-menu-item']//span[@class='cta-button__text']"));
    }
}