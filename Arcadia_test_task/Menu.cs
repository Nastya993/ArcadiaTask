using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcadia_test_task
{
    class Menu : BaseClass
    {
        public By menuButton = By.XPath("//div[@class='main_navigation']//a[@class='menu_trigger']");
        public By whoWeAreButton = By.XPath("//ul[@id='menu']//a[text()='Who we are']");
        public By managementTeamButton = By.XPath("//ul[@id='menu']//a[text()='Management team']");

        public void ClickManageTeamButton()
        {
            ClickElement(menuButton);
            ClickElement(whoWeAreButton);
            ClickElement(managementTeamButton);            
        }
    }
}
