using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Basics;

public class EpamContentTextTests
{
    private IWebDriver driver { get; set; }
    private bool disposed = false;
    private string epamUrl = "https://www.epam.com/";
    private WebDriverWait waiter;

    [SetUp]
    public void SetupBrowser()
    {
        var options = new ChromeOptions();
        options.BinaryLocation = "/Applications/Google Chrome.app/Contents/MacOS/Google Chrome";
        driver = new ChromeDriver(options);
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
        waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        IWebElement AcceptAllCookiesButton = driver.FindElement(By.Id("onetrust-accept-btn-handler"));
        Thread.Sleep(3000);
        AcceptAllCookiesButton.Click();
    }
    
    [TearDown]
    public void TearDown()
    {
        driver.Dispose();
    }
    
    [Test]
    public void CheckThatListOfCountriesContainsAmerEMEAandAPAC()
    {
        driver.FindElement(By.XPath("//a[@ href='/careers']//parent::span")).Click();
        driver.FindElement(By.XPath("(//*[name()='use'])[10]")).Click();
        bool isAmericasDisplayed = driver.FindElement(By.XPath("//a[@data-item='0']")).Displayed;
        bool isEMEADisplayed = driver.FindElement(By.XPath("//a[@data-item='1']")).Displayed;
        bool isAPACDisplayed = driver.FindElement(By.XPath("//a[@data-item='2']")).Displayed;
        
        Assert.True(isAmericasDisplayed, "Americas element not displayed");
        Assert.True(isEMEADisplayed, "EMEA element not displayed");
        Assert.True(isAPACDisplayed, "APAC element not displayed");
    }
    
    [Test]
    public void CheckThatUrlToSearchContainsMyText()
    {
        var keyWord = "Automation";
        var searchUrl = "https://www.epam.com/search?q=Automation";
        
        driver.FindElement(By.XPath("//span[@class='search-icon dark-iconheader-search__search-icon']")).Click();
        Thread.Sleep(1000);
        driver.FindElement(By.XPath("//input[@id='new_form_search']")).Click();
        driver.FindElement(By.XPath("//input[@id='new_form_search']")).SendKeys(keyWord);
        driver.FindElement(By.XPath("//span[@class='bth-text-layer']")).Click();
        
        Assert.That(driver.Url,Is.EqualTo(searchUrl), "The url is wrong");

        var listOfArticles = driver.FindElements(By.XPath("//article")).ToList().Take(5);
        var articlesToLower = listOfArticles.Select(article=>article.Text.ToLower());
        var expectedResult = keyWord.ToLower();
        string output = string.Join(",", articlesToLower);
        Assert.That(articlesToLower.All(article => article.Contains(expectedResult)),Is.True, $"The first 5 articles don't contain entered text : {output}");
    }
    
    [Test]
    public void CheckThatTitleOfTheOpenedPageEqualsSearchTitle()
    {
        var keyWord = "Business Analysis";
        var searchUrl = "https://www.epam.com/search?q=Business+Analysis";
        
        var searchButton = driver.FindElement(By.XPath("//span[@class='search-icon dark-iconheader-search__search-icon']"));
        searchButton.Click();
        waiter.Until(d => d.FindElement(By.XPath("//input[@id='new_form_search']")).Displayed);
        driver.FindElement(By.XPath("//input[@id='new_form_search']")).Click();
        driver.FindElement(By.XPath("//input[@id='new_form_search']")).SendKeys(keyWord);
        driver.FindElement(By.XPath("//span[@class='bth-text-layer']")).Click();
        
        Assert.That(driver.Url,Is.EqualTo(searchUrl), "The url is wrong");
        
        var firstArticleTitle = driver.FindElement(By.XPath("//a[@class='search-results__title-link']")).Text;
        waiter.Until(d => d.FindElement(By.XPath("//a[@class='search-results__title-link']")));
        var searchResults = driver.FindElement(By.XPath("//a[@class='search-results__title-link']"));
        searchResults.Click();
        var openedArticleTitle = driver.FindElement(By.XPath("//span[@class='font-size-80-33']")).Text;
        Assert.That(firstArticleTitle, Is.EqualTo(openedArticleTitle), "Titles are different");
    }

    [Test]
    public void WriteXPathLocators()
    {
        bool firstElement = driver.FindElement(By.XPath("//*[contains (@class, 'cookie')]//child::*[@class='iparys_inherited']")).Displayed;
        bool secondElement = driver.FindElement(By.XPath("//div[@id='wrapper']//following-sibling::*[@class='header-container iparsys parsys']")).Displayed;
        bool thirdElement = driver.FindElement(By.XPath("//button[@class='location-selector__button']")).Displayed;
        bool fourthElement = driver.FindElement(By.Id("onetrust-accept-btn-handler")).Displayed;
        bool fifthElement = driver.FindElement(By.XPath("//div[@class='header-container iparsys parsys']//child::*[@class='header-ui-23']")).Displayed;
        
        //assertions
        Assert.True(firstElement, "First element not displayed");
        Assert.True(secondElement, "Second element not displayed");
        Assert.True(thirdElement, "Third element not displayed");
        Assert.True(fourthElement, "Fourth element not displayed");
        Assert.True(fifthElement, "Fifth element not displayed");
    }
}