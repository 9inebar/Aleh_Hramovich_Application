using OpenQA.Selenium;

namespace InClassTesting;

public class CookiesBlock
{
    private IWebDriver driver;
    public CookiesBlock(IWebDriver driver)
    {
        driver = this.driver;
    }
    public IWebElement acceptCookiesButton => driver.FindElement(By.Id("onetrust-accept-btn-handler"));
}