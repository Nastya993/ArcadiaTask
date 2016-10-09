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

        public void ClickMenuButton()
        {
            ClickElement(menuButton);                    
        }

        public void ClickWhoWeAreButton()
        {
            ClickElement(whoWeAreButton);   
        }

        public void ClickManagementTeamButton()
        {
            ClickElement(managementTeamButton);
        }
    }
}
