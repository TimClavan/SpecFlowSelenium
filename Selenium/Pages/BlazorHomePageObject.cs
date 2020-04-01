using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Blazor
{
    public class BlazorHomePageObject
    {
        private readonly ChromeDriver _chromeDriver;

        public BlazorHomePageObject()
        {
            _chromeDriver = new ChromeDriver();
        }

        public void NavigeerNaarBlazor()
        {
            _chromeDriver.Navigate().GoToUrl("https://blazor-demo.github.io/");
        }
        public string ControleerTitel()
        {
           return _chromeDriver.FindElement(By.XPath("//*[@class='col-sm-9']/component/h1[.='Hello, world!']")).Text;
        }
    }
}