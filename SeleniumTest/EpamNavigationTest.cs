using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest;

public class Tests
{
    private IWebDriver driver = new ChromeDriver();
    

    [Test]
    public void Test1()
    {
        var epamUrl = "https://www.epam.com";
        
        driver.Manage().Window.Maximize();
        
        driver.Navigate().GoToUrl(epamUrl);
        
        Assert.That(driver.Url.Equals(epamUrl), "Incorrect ");
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}