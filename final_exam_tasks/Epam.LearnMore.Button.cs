using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace final_exam_tasks;

public class Epam_LearnMore_Button
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
        driver.Quit();
    }

    [Test]
    public void HoverOverCareerMenuTest()
    {
        var learnMoreUTL = By.XPath("//*[contains(text(),'Learn More')]");
        bool IslearnMoreUTLDispalyed = driver.FindElement(By.XPath("//*[contains(text(),'Learn More')]")).Displayed;
        
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(epamUrl);
        action.MoveToElement(driver.FindElement(By.XPath("//*[text()='Careers']//ancestor::*[@class='top-navigation__item-link js-op']"))).Build().Perform();
        waiter.Until(d=>d.FindElement(learnMoreUTL).Enabled);
        Assert.True(IslearnMoreUTLDispalyed, "the element is not displayed");
    }
}