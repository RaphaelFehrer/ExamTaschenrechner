using System;
using TechTalk.SpecFlow;
using Xunit;

namespace testExamTaschenrechner
{
    [Binding]
    public class TaschenrechnerSteps
    {
        double number, result;

        [Given(@"the number is (.*)")]
        public void GivenTheNumberIs(double p0)
        {
            number = p0;
        }
        
        [When(@"the equation is sinus")]
        public void WhenTheEquationIsSinus()
        {
            result = Math.Sin(number);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double p0)
        {
            double expected = p0;
            double actual = result;
            Assert.Equal(expected, actual, 5);
        }

        [When(@"the equation is cosinus")]
        public void WhenTheEquationIsCosinus()
        {
            result = Math.Cos(number);
        }

        [When(@"the equation is tangens")]
        public void WhenTheEquationIsTangens()
        {
           result = Math.Tan(number);
        }


    }
}
