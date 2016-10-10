using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcadia_test_task
{
    class ManagementTeamPage : BasePage
    {
        By title = By.XPath("//h1[text()='Management team']");
        By firstImage = By.XPath("//image");

        /*
         * menu, Portfolio, LinkedIn elements are present, footer 
         * (Contact Us, T&Cs etc) is present, Management team title 
         * is present)
	     * Verify that the URL of the first image is present.
         * */

        public bool IsTitlePresent()
        {
            return IsElementDisplayed(title);
        }

        public bool HasFirsImageLink()
        {
            return HasParentAttibute(By.XPath("//img"), "href");
        }
    }
}
