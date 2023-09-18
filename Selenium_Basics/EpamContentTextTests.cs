using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Basics;

public class EpamContentTextTests
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
        IWebElement AcceptAllCookiesButton = driver.FindElement(By.Id("onetrust-accept-btn-handler"));
        Thread.Sleep(3000);
        AcceptAllCookiesButton.Click();
    }
    
    [TearDown]
    public void TearDown()
    {
        driver.Quit();
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
        Thread.Sleep(2000);
        driver.FindElement(By.XPath("//input[@id='new_form_search']")).Click();
        driver.FindElement(By.XPath("//input[@id='new_form_search']")).SendKeys(keyWord);
        driver.FindElement(By.XPath("//span[@class='bth-text-layer']")).Click();
        
        Assert.That(driver.Url,Is.EqualTo(searchUrl), "The url is wrong");
        
        var firstArticleTitle = driver.FindElement(By.XPath("//a[@class='search-results__title-link']")).Text;
        Thread.Sleep(1000);
        var searchResults = driver.FindElement(By.XPath("//a[@class='search-results__title-link']"));
        searchResults.Click();
        var openedArticleTitle = driver.FindElement(By.XPath("//span[@class='font-size-80-33']")).Text;
        Assert.That(firstArticleTitle, Is.EqualTo(openedArticleTitle), "Titles are different");
    }

    [Test]
    public void WriteXPathLocators()
    {
        driver.FindElement(By.XPath("//*[contains (@class, 'cookie')]//child::*[@class='iparys_inherited']"));
        driver.FindElement(By.XPath("//div[@id='wrapper']//following-sibling::*[@class='header-container iparsys parsys']"));
        driver.FindElement(By.XPath("//div[@class='header-search__panel']//parent::h3"));
        driver.FindElement(By.Id("onetrust-accept-btn-handler"));
        driver.FindElement(By.XPath("//div[@class='header-container iparsys parsys']//child::*[@class='header-ui-23']"));
    }
}