using OpenQA.Selenium;

namespace InClassTesting;

public class EpamSearchResultsPage
{
    private IWebDriver driver;
    public EpamSearchResultsPage(IWebDriver driver)
    {
        driver = this.driver;
    }
    public List<IWebElement> SearchResults => driver.FindElements(By.TagName("article")).ToList();
}