using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace stop_net.tests.integration
{
    [Binding]
    public class StepDefinitions
    {
        [Given(@"I am curious")]
        public void GivenIAmCurious()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I request the version")]
        public void WhenIRequestTheVersion()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I yell '(.*)'")]
        public void WhenIYell(string exclamation)
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"the result is content")]
        public void ThenTheResultIsContent()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"the result is constant")]
        public void ThenTheResultIsConstant()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I hear '(.*)' echoed back")]
        public void ThenIHearEchoedBack(string exclamation)
        {
            //ScenarioContext.Current.Pending();
        }
    }
}