using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Advanced;

public class SeleniumAdvancedTests
{
    private IWebDriver driver { get; set; }
    private string epamUrl = "https://www.epam.com/";
    private Actions action;
    private WebDriverWait waiter;
    
    [SetUp]
    public void SetupBrowser()
    {
        var options = new ChromeOptions();
        options.BinaryLocation = "/Applications/Google Chrome.app/Contents/MacOS/Google Chrome";
        driver = new ChromeDriver(options);
        action = new Actions(driver);
        waiter = new WebDriverWait(driver, TimeSpan.MaxValue);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
    }
    
    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }

    [Test]
    public void HoverOverCareerMenuTest()
    {
        var jobListingsUrl = "https://www.epam.com/careers/job-listings";
        
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
        action.MoveToElement(driver.FindElement(By.XPath("//*[text()='Careers']//ancestor::*[@class='top-navigation__item-link js-op']"))).Build().Perform();
        Thread.Sleep(3000);
        action.MoveToElement(driver.FindElement(By.XPath("//*[@href='/careers/job-listings']//parent::*[@class='hamburger-menu__link']"))).Click().Build().Perform();
        //Assert.That(driver.Url,Is.EqualTo(jobListingsUrl), "the opened page has wrong url");
    }
    [Test]
    public void VerifyListOfLangIsCorrect()
    {
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
        action.MoveToElement(driver.FindElement(By.XPath("//div[@class='location-selector__button-language-prefix']//ancestor::button[@class='mobile-location-selector__button']"))).Click().Build().Perform();
    }
}