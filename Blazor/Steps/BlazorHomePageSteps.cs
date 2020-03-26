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
        
        [Then(@"the text ""(.*)"" is present")]
        public void ThenTheTextIsPresent(string p0)
        {
            automationTestSite.DoesElementExistOnPage(PageName.Home, Element.H1);
            //ScenarioContext.Current.Pending();
        }

        [Then(@"the text Welcome to your new single-page application\. is present")]
        public void ThenTheTextWelcomeToYourNewSingle_PageApplication_IsPresent()
        {
            automationTestSite.DoesElementExistOnPage(PageName.Home, Element.Text);
        }

    }
}
