using System;
using TechTalk.SpecFlow;

namespace Blazor.Steps
{
    [Binding]
    public class BlazorSteps
    {
        [Given(@"I navigate to the home page")]
        public void GivenINavigateToTheHomePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the homepage is loaded")]
        public void WhenTheHomepageIsLoaded()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the text ""(.*)"" is present")]
        public void ThenTheTextIsPresent(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
