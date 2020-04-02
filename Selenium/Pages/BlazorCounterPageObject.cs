using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Blazor
{
    public class BlazorCounterPageObject
    {
        private readonly ChromeDriver _chromeDriver;

        public BlazorCounterPageObject()
        {
            _chromeDriver = new ChromeDriver();
        }

        public void NavigeerNaarBlazorCounterPage()
        {
            _chromeDriver.Navigate().GoToUrl("https://blazor-demo.github.io/Counter");
        }

        public string ControleerTitel()
        {
            return _chromeDriver.FindElement(By.XPath("//*[@class='col-sm-9']/component/h1[.='Counter']")).Text;
        }

        public string ControleerTekst()
        {
            return _chromeDriver.FindElement(By.XPath("//*[@class='col-sm-9']/component/p[.='This is a simple example of a component.']")).Text;
        }

        public void IncrementButton()
        {
            _chromeDriver.FindElement(By.XPath("//*[@class='col-sm-9']/component/button")).Click();
        }


        public void ControleerCount()
        {
            _chromeDriver.FindElement(By.XPath("//*[@class='col-sm-9']/component/strong"));

        }
    }
}
