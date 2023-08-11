using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Basics;

public class SeleniumTests
{
    private IWebDriver driver { get; set; }

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
        
        var epamUrl = "https://www.epam.com/";
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
        Assert.That(driver.Url,Is.EqualTo(epamUrl), "Landing page is not displayed correctly");
    }
    
    [Test]
    public void CheckThatGoBackToPreviousPageWorks()
    {
        var epamUrl = "https://www.epam.com/";
        var howUrl = "https://www.epam.com/how-we-do-it";
        
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
        driver.Navigate().GoToUrl(howUrl);
        driver.Navigate().GoToUrl("https://www.epam.com/our-work");
        driver.Navigate().Refresh();
        driver.Navigate().Back();
        Assert.That(driver.Url,Is.EqualTo(howUrl), "Navigation back works incorrectly");
    }
    
    [Test]
    public void CreateAndFindSimpleLocators()
    {
        var epamUrl = "https://www.epam.com/";

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
        var epamUrl = "https://www.epam.com/";

        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
        driver.FindElement(By.XPath("//*[@class='hamburger-menu__item cta-button-menu-item']//span[@class='cta-button__text']"));
    }
    
    [Test]
    public void CheckThatListOfCountriesContainsAmerEMEAandAPAC()
    {
        var epamUrl = "https://www.epam.com/";

        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
        driver.FindElement(By.XPath("//*[text()='Careers']//ancestor::*[@class='top-navigation__item-text']")).Click();
        driver.FindElement(By.XPath("(//*[name()='use'])[10]")).Click();
        bool Americas = driver.FindElement(By.XPath("//a[@data-item='0']")).Displayed;
        bool EMEA = driver.FindElement(By.XPath("//a[@data-item='1']")).Displayed;
        bool APAC = driver.FindElement(By.XPath("//a[@data-item='2']")).Displayed;
        
        Assert.True(Americas, "not displayed");
        Assert.True(EMEA, "not displayed");
        Assert.True(APAC, "not displayed");
    }
    
    [Test]
    public void CheckThatUrlToSearchContainsMyText()
    {
        var epamUrl = "https://www.epam.com/";
        var searchUrl = "https://www.epam.com/search?q=Automation";
        var keyWord = "Automation";
            
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
        driver.FindElement(By.XPath("//div[@class='header-search-ui header-search-ui-23 header__control']")).Click();
        Thread.Sleep(1000);
        driver.FindElement(By.XPath("//input[@id='new_form_search']")).Click();
        driver.FindElement(By.XPath("//input[@id='new_form_search']")).SendKeys(keyWord);
        driver.FindElement(By.XPath("//span[@class='bth-text-layer']")).Click();
        
        Assert.That(driver.Url,Is.EqualTo(searchUrl), "The url is wrong");

        var ListOfArticles = driver.FindElements(By.XPath("//article")).ToList().Take(5);
        var ArticlesToLower = ListOfArticles.Select(article=>article.Text.ToLower());
        string Output = string.Join(",", ArticlesToLower);
        foreach (var article in ArticlesToLower)
        {
            var a = article.Contains(keyWord.ToLower());
        }
        Assert.That(ArticlesToLower.All(article => article.Contains(keyWord.ToLower())),Is.True, $"Search criteria is not met: {Output}");
    }
    
    [Test]
    public void CheckThatTitleOfTheOpenedPageEqualsSearchTitle()
    {
        var epamUrl = "https://www.epam.com/";
        var searchUrl = "https://www.epam.com/search?q=Business+Analysis";
        var keyWord = "Business Analysis";
            
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
        driver.FindElement(By.XPath("//div[@class='header-search-ui header-search-ui-23 header__control']")).Click();
        Thread.Sleep(2000);
        driver.FindElement(By.XPath("//input[@id='new_form_search']")).Click();
        driver.FindElement(By.XPath("//input[@id='new_form_search']")).SendKeys(keyWord);
        driver.FindElement(By.XPath("//span[@class='bth-text-layer']")).Click();
        
        Assert.That(driver.Url,Is.EqualTo(searchUrl), "The url is wrong");
        
        var firstArticleTitle = driver.FindElement(By.XPath("//a[@class='search-results__title-link'][1]")).Text;
        Console.WriteLine(firstArticleTitle);
        driver.FindElement(By.XPath("//button[@id='onetrust-accept-btn-handler']")).Click();
        Thread.Sleep(1000);
        driver.FindElement(By.XPath("//a[@class='search-results__title-link'][1]")).Click();
        var openedArticleTitle = driver.FindElement(By.XPath("//span[@class='museo-sans-light']")).Text;
        Console.WriteLine(openedArticleTitle);
        
        Assert.That(firstArticleTitle, Is.EqualTo(openedArticleTitle), "Titles are different");
    }

    [Test]
    public void WriteXPathLocators()
    {
        var epamUrl = "https://www.epam.com/";
        
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
        
        driver.FindElement(By.XPath("//*[contains (@class, 'cookie')]//child::*[@class='iparys_inherited']"));
        driver.FindElement(By.XPath("//div[@id='wrapper']//following-sibling::*[@class='header-container iparsys parsys']"));
        driver.FindElement(By.XPath("//div[@class='header-search__panel']//parent::h3"));
        driver.FindElement(By.XPath("//button[@class='hamburger-menu__button']")).Click(); //for the next locator to find
        driver.FindElement(By.XPath("//li[@class='  hamburger-menu__item item--collapsed '][last()]"));
        driver.FindElement(By.XPath("//div[@class='header-container iparsys parsys']//child::*[@class='header-ui-23']"));
    }
    
}

