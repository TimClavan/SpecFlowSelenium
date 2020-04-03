using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

<<<<<<< HEAD
 

=======
>>>>>>> fd3a4c3500b8eb92b328505ea08a29368e4ff9ee
namespace Blazor
{
    public class BlazorHomePageObject
    {
        private readonly ChromeDriver _chromeDriver;

        public BlazorHomePageObject()
        {
            _chromeDriver = new ChromeDriver();
        }

<<<<<<< HEAD


=======
>>>>>>> fd3a4c3500b8eb92b328505ea08a29368e4ff9ee
        public void NavigeerNaarBlazor()
        {
            _chromeDriver.Navigate().GoToUrl("https://blazor-demo.github.io/");
        }
        public string ControleerTitel()
        {
<<<<<<< HEAD
            return _chromeDriver.FindElement(By.XPath("//*[@class='col-sm-9']/component/h1[.='Hello, world!']")).Text;
        }

        public string ControleerTekst()
        {
            return _chromeDriver.FindElement(By.XPath("//*[@class='col-sm-9']/component/p[.='Welcome to your new single-page application.']")).Text;
=======
           return _chromeDriver.FindElement(By.XPath("//*[@class='col-sm-9']/component/h1[.='Hello, world!']")).Text;
>>>>>>> fd3a4c3500b8eb92b328505ea08a29368e4ff9ee
        }
    }
}