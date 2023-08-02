using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Basics;

public class LectureWork
{
    private IWebDriver driver { get; set; }

    [SetUp]
    public void SetupBrowser()
    {
        var options = new ChromeOptions();
        options.BinaryLocation = "/Applications/Google Chrome.app/Contents/MacOS/Google Chrome";
        driver = new ChromeDriver(options);
    }

    [Test]
    public void Test1()
    {
        var epamUrl = "https://www.epam.com/";
        var epamAbout = "https://www.epam.com/about";

        driver.Manage().Window.Maximize();

        driver.Navigate().GoToUrl(epamUrl);
        
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }

    [Test]
    public void Test2()
    {
        var epamUrl = "https://www.epam.com/";
        //var epamAbout = "https://www.epam.com/about";

        driver.Manage().Window.Maximize();

        driver.Navigate().GoToUrl(epamUrl);

        driver.FindElement(By.XPath("//*[@class='search-icon dark-iconheader-search__search-icon']")).Click();
        driver.FindElement(By.XPath("//*[@id='new_form_search']")).Click();
        driver.FindElement(By.XPath("//*[@class='bth-text-layer']"));
        driver.FindElement(By.XPath(
            "//*[@href='/about/newsroom/in-the-news/2020/how-epam-systems-uses-automation-to-transform-businesses']//ancestor::article"));
    }

    [TearDown]
    public void TearDown2()
    {
        driver.Quit();
    }

    [Test]
    public void Test3()
    {
        var epamUrl = "https://www.epam.com/";
        var epamAContactUs = "https://www.epam.com/about/who-we-are/contact";
        var expectedTitle = "Contact Us";
        var expectedAddress = "41 University Drive • Suite 202,Newtown, PA 18940 • USA";

        driver.Manage().Window.Maximize();

        driver.Navigate().GoToUrl(epamUrl);

        var searchContactUsName = By.XPath("//span[contains(@class,'cta-button__text')]");
        var searchAddress = By.XPath("////*[contains(@class, 'colctrl__holder')]//*[@class='text'][last()]//p");
        var actualAddress = driver.FindElement(searchAddress).Text;
        var actualCU = driver.FindElement(searchContactUsName).Text;
        Assert.That(actualAddress, Is.EqualTo(expectedAddress), "Invalid Address");
        Assert.That(actualCU, Is.EqualTo(expectedTitle), "Invalid Title");
    }

    [TearDown]
    public void TearDown3()
    {
        driver.Quit();
    }
}