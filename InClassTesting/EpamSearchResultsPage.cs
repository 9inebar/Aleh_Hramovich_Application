using OpenQA.Selenium;

namespace InClassTesting;

public class EpamSearchResultsPage
{
    private IWebDriver driver;
    public EpamSearchResultsPage(IWebDriver driver)
    {
        this.driver = driver;
    }
    public List<IWebElement> SearchResults => driver.FindElements(By.TagName("article")).ToList();
}