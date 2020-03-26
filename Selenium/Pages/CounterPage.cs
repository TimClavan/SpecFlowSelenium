using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Support;

namespace Selenium.Pages
{
    public class CounterPage : TestPage
    {
        public CounterPage(ChromeDriver webDriver)
        {
            Setup(WebDriver);
            Name = PageName.Counter;
            Url = "https://blazor-demo.github.io/Counter";
        }

        protected sealed override Collection<Locator> InitializeLocators()
        {
            return new Collection<Locator>
            {
                new Locator(Element.H1, By.XPath("//*[@id=_e6]/h1"))
                
            };
        }

    }
}
