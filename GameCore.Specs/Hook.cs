using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace GameCore.Specs
{
    [Binding]
    public class Hook : Steps
    {
        [BeforeScenario("setupData")]
        public void BeforeScenario()
        {

        }
        [AfterScenario("elf")]
        public void AfterScenario()
        {

        }
    }
}
