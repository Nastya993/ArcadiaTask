using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcadia_test_task.Pages.Economy
{
    class LegalMediaPage : BasePage
    {
        By financialInfo = By.XPath("//h2[text()='International Financial Law Review']/../p");
        By financialLink = By.XPath("//h2[text()='International Financial Law Review']/../p/a");
        
        public bool IsFinancialInfoDiaplyed()
        {
            return IsElementDisplayed(financialInfo);
        }

        public void ClickFinancialLink()
        {
            ClickElement(financialLink);
        }
    }
}
