using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Blazor
{
    [Binding]
    public class BlazorHomePageBinding
    {
        private readonly BlazorHomePageObject _blazorHomePage;

        public BlazorHomePageBinding(BlazorHomePageObject blazorHomePage)
        {
            _blazorHomePage = blazorHomePage;
        }

        //JoelTest
        [Given(@"ik navigeer naar de home page")]
        public void GegevenIkNavigeerNaarDeHomePage()
        {
            _blazorHomePage.NavigeerNaarBlazor();
            Thread.Sleep(5000);
        }
        

        [Then(@"wordt de titel ""(.*)"" getoond")]
        public void ThenWordtDeTitelGetoond(string titel)
        {
          StringAssert.AreEqualIgnoringCase(titel, _blazorHomePage.ControleerTitel());
        }

    }
}