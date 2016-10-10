using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcadia_test_task
{
    class EuroMoneyPlsHomePage : BasePage
    {
        public string BASEURL = "http://www.euromoneyplc.com";

        public EuroMoneyPlsHomePage(IWebDriver driver)
            :base(driver)
        {

        }

        public void GoToHomePage()
        {
            GoToURL(BASEURL);
        }
     }
}
