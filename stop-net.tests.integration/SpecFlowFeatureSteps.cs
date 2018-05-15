using System;
using TechTalk.SpecFlow;

namespace stop_net.tests.integration
{
    [Binding]
    public class SpecFlowFeatureSteps
    {
        public int _p0 { get; private set; }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _p0 = p0;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            _p0 = p0;
        }
    }
}
