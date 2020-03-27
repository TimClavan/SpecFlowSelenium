using NUnit.Framework;
using Selenium.Pages;
using Selenium.Support;
using TechTalk.SpecFlow;

namespace Blazor.Steps
{
    [Binding]
    public class BlazorHomePageSteps
    {
        private AutomationTestSite automationTestSite;

        public BlazorHomePageSteps(AutomationTestSite automationTestSite)
        {
            this.automationTestSite = automationTestSite;
        }

        [Given(@"I navigate to the home page")]
        public void GivenINavigateToTheHomePage()
        {
            automationTestSite.GoTo();
        }
        
        [When(@"the homepage is loaded")]
        public void WhenTheHomepageIsLoaded()
        {
            automationTestSite.PageLoaded();
        }

        [Then(@"the text Hello, World! is present")]
        public void ThenTheTextHelloWorldIsPresent()
        {
            Assert.IsTrue(automationTestSite.DoesTextExistOnPage(PageName.Home, Element.H1));
        }


        [Then(@"the text ""(.*)"" is present")]
        public void ThenTheTextIsPresent(string p0)
        {
            Assert.IsTrue(automationTestSite.DoesTextExistOnPage(PageName.Home, Element.H1));
            //ScenarioContext.Current.Pending();
        }

        [When(@"I click on the counter link")]
        public void WhenIClickOnTheCounterLink()
        {
            automationTestSite.ClickElementOnPage(PageName.Home, Element.CounterLink);
            
        }

        [When(@"I click on the Incrmeent button")]
        public void WhenIClickOnTheIncrmeentButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the current count is ""(.*)""")]
        public void ThenTheCurrentCountIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }


    }
}
