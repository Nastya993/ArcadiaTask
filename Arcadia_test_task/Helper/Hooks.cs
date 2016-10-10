using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Arcadia_test_task
{
    [Binding]
    class Hooks
    {
        [BeforeTestRun] 
        public static void Before()
        {
            BaseClass.driver = new ChromeDriver();
            BaseClass.driver.Manage().Window.Size = new System.Drawing.Size(1024,600);
        }

        [AfterTestRun]
        public static void After()
        {
            BaseClass.driver.Quit();
        }
    }
}
