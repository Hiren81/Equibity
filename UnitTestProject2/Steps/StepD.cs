using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UnitTestProject2;

namespace UnitTestProject2.Steps
{
    [Binding]
    class StepD 
    {
        [Given(@"I am filling the contact us page")]
        public void GivenIAmFillingTheContactUsPage()
        {
            tempClass c = new tempClass();

            c.Initialize();
            c.OpenTest();
            c.EndTest();

        }

        [Then(@"the web page is filled successfully")]
        public void ThenTheWebPageIsFilledSuccessfully()
        {
            
        }

    }
}



