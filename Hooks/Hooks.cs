using SpecFlowMarsApplication.Utilities;
using TechTalk.SpecFlow;

namespace SpecFlowMarsApplication.Hooks
{
    [Binding]
    public sealed class Hooks:CommonDriver
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            Setup();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Close();
        }
    }
   
    
}