using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Support;

namespace Selenium.Pages
{
    public class HomePage : TestPage
    {
        public HomePage(ChromeDriver webDriver)
        {
            Setup(webDriver);
            Name = PageName.Home;
            Url = "https://blazor-demo.github.io/";

        }

        protected sealed override Collection<Locator> InitializeLocators()
        {
            return new Collection<Locator>
            {
                new Locator(Element.H1, By.XPath("//*[@id='_e2']/h1")),
                //new Locator(Element.Text, By.XPath("//*[@id=_e2]/p")),
                //new Locator(Element.CounterLink, By.XPath("//*[@id='_e3']"))
            };
        }


    }
}