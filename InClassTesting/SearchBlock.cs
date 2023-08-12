using OpenQA.Selenium;

namespace InClassTesting;

public class SearchBlock
{
    private IWebDriver driver;
    public SearchBlock(IWebDriver driver)
    {
        this.driver = driver;
    }
    public IWebElement SearchInput => driver.FindElement(By.XPath("//*[@id = 'new_form_search']"));
    public IWebElement FindButton => driver.FindElement(By.XPath("//span [contains (@class, 'bth')]"));
}