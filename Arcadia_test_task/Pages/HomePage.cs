using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcadia_test_task
{
    class HomePage : Menu
    {
        string url = "/";
        public void GoToHomePage()
        {
            GoToURL(BASEURL + url);
        }
        public Footer footer = new Footer();        
    }
}
