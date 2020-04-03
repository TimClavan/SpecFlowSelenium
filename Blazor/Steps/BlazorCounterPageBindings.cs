using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Blazor
{
    [Binding]
    public class CounterPageBinding
    {
        private readonly BlazorCounterPageObject _blazorCounterPage;


        public CounterPageBinding(BlazorCounterPageObject blazorCounterPage)
        {
            _blazorCounterPage = blazorCounterPage;
        }

        [Given(@"ik navigeer naar de counter page")]
        public void GivenIkNavigeerNaarDeCounterPage()
        {
            _blazorCounterPage.NavigeerNaarBlazorCounterPage();
            Thread.Sleep(5000);
        }

        [Then(@"wordt de titel ""(.*)"" op de counter page getoond")]
        public void ThenWordtDeTitelOpDeCounterPageGetoond(string titel)
        {
            StringAssert.AreEqualIgnoringCase(titel, _blazorCounterPage.ControleerTitel());
        }


        [Then(@"wordt de tekst ""(.*)"" op de counter page getoond")]
        public void ThenWordtDeTekstGetoond(string tekst)
        {
            StringAssert.AreEqualIgnoringCase(tekst, _blazorCounterPage.ControleerTekst());
        }

        [When(@"ik klik op de increment button")]
        public void WhenIkKlikOpDeCounterButton()
        {

            _blazorCounterPage.IncrementButton();

        }

        [Then(@"is de current count (.*)")]
        public void ThenIsDeCurrentCount(string p0)
        {

            StringAssert.AreEqualIgnoringCase(p0, _blazorCounterPage.ControleerCount());
            //_blazorCounterPage.ControleerCount()
            //_blazorCounterPage.ControleerCount( str, Table table);
            // ScenarioContext.Current.Pending();
        }



    }
}
