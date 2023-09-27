using NUnit.Framework;
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
        waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
    }
    
    [TearDown]
    public void TearDown()
    {
        driver.Dispose();
    }

    [Test]
    public void HoverOverCareerMenuTest()
    {
        var jobListingsUrl = "https://www.epam.com/careers/job-listings";
        
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
        action.MoveToElement(driver.FindElement(By.XPath("//*[text()='Careers']//ancestor::*[@class='top-navigation__item-link js-op']"))).Build().Perform();
        waiter.Until(d=>d.FindElement(By.XPath("//a[@href='/careers/job-listings']//parent::li[contains(@class, 'top')]")).Enabled);
        action.MoveToElement(driver.FindElement(By.XPath("//a[@href='/careers/job-listings']//parent::li[contains(@class, 'top')]"))).Click().Build().Perform();
        Assert.That(driver.Url,Is.EqualTo(jobListingsUrl), "the opened page has wrong url");
    }
    
    [Test]
    public void VerifyListOfLangIsCorrect()
    {
        var listOfLanguages = new List<string> { "Global (English)", "Česká Republika (Čeština)", "Czech Republic (English)", "DACH (Deutsch)", "Hungary (English)", "India (English)", "日本 (日本語)","Polska (Polski)","СНГ (Русский)", "Україна (Українська)", "中国 (中文)"};
        
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
        driver.FindElement(By.XPath("//button[@class='location-selector__button']")).Click();
        waiter.Until(d => d.FindElement(By.XPath("//nav[@class='location-selector__panel']")));
        var listOfActualLanguages =
            driver.FindElements(By.XPath("//li[@class='location-selector__item']")).ToList().Select(l => l.GetAttribute("outerText"));
        CollectionAssert.AreEquivalent(listOfLanguages,listOfActualLanguages, "the list of languages is not correct");
    }

    [Test]
    public void CheckThatThereAre20Elements()
    {
        var numberOfArticles = 20;
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
        driver.FindElement(By.XPath("//div[@class='header-search-ui header-search-ui-23 header__control']")).Click();
        driver.FindElement(By.XPath("//li[@class='frequent-searches__item'][1]")).Click();
        driver.FindElement(By.XPath("//span[@class='bth-text-layer']")).Click();
        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
        jse.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        waiter.Until(d => d.FindElement(By.XPath("//article[@class='search-results__item'][11]")));
        var listOfArticlesAfterViewMore = driver.FindElements(By.XPath("//article")).Count;
        Assert.That(listOfArticlesAfterViewMore,Is.EqualTo(numberOfArticles), "the number of articles is wrong");
    }
}