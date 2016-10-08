using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcadia_test_task
{
    class ManagementTeamPage : Menu
    {
        By title = By.XPath("//h1[text()='Management team']");

        public bool IsTitlePresent()
        {
            return IsElementDisplayed(title);
        }
    }
}
