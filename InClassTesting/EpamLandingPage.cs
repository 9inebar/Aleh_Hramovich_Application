using OpenQA.Selenium;

namespace InClassTesting;

public class EpamLandingPage
{
    private IWebDriver driver;

    public EpamLandingPage(IWebDriver driver)
    {
        this.driver = driver;
    }
    public IWebElement SearchButton => driver.FindElement(By.XPath("//*[@class='header-search__button header__icon']"));
    public SearchBlock EpamSearchBlock => new SearchBlock(driver);
    public CookiesBlock EpamCookiesBlock => new CookiesBlock(driver);
}