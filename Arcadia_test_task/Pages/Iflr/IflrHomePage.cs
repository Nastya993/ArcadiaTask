using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcadia_test_task.Pages
{
    class IflrHomePage : BaseClass
    {
        public string url = "http://www.iflr.com";
        By subscribeButton = By.XPath("//a[text()='Subscribe']");
        public void ClickSubscribeButton()
        {
            ClickElement(subscribeButton);
        }

    }
}
