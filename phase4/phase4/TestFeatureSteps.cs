using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace phase4
{
    [Binding]
    public class TestFeatureSteps
    {
        private string text = "BBQ,SMALL";
        [Given(@"the following Data :")]
        public void GivenTheFollowingData()
        {
            var text = "BBQ,SMALL";
          //  ScenarioContext.Current.TryAdd(text);
        }
        
        [Then(@"MY BIDING SHOULD DO THAT")]
        public void ThenMYBIDINGSHOULDDOTHAT()
        {
            var actual= "BBQ,SMALL";
            var expexted = "BBQ,SMALL";
            if (!actual.Equals(expexted))
            {
                Assert.Fail("somthing wrong");
            }
            //ScenarioContext.Current.Pending();
        }
    }
}
