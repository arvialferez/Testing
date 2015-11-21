using Events.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI;

namespace TestRunnerConsole
{
    class Runner
    {
        public void Start()
        {
            TaggingWebApiTest test = new TaggingWebApiTest();
            test.Setup();
            test.BrowserTest();
            
        }
    }
}
