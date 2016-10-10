using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcadia_test_task.Pages.Iflr
{
    class SubscriptionGroupsPage : BaseClass
    {
        By personaSelectButton = By.XPath("//table//tr[4]//td[1]/a");

        public SubscriptionGroupsPage(IWebDriver driver)
            :base(driver)
        {
        }

        public void ClickPersonaSelectButton()
        {
            ClickElement(personaSelectButton);
        }
    }
}
