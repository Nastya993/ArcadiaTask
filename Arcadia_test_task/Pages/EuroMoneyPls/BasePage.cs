using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcadia_test_task
{
    class BasePage : BaseClass
    {
        public By menuButton = By.XPath("//div[@class='main_navigation']//a[@class='menu_trigger']");
        public By whoWeAreButton = By.XPath("//ul[@id='menu']//a[text()='Who we are']");
        public By managementTeamButton = By.XPath("//ul[@id='menu']//a[text()='Management team']");
        public By ourPortfolioButton = By.XPath("//ul[@id='menu']/li/a[text()='Our portfolio']");
        public By legalMediaButton = By.XPath("//ul[@id='menu']//a[text()='Legal media']");
        public By logo = By.XPath("//span[@class='header_logo']//img");
        public By portfolio = By.XPath("//span[text()='Portfolio']");

        public BasePage(IWebDriver driver)
            : base(driver)
        {

        }

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

        public void ClickOurPortfolio()
        {
            ClickElement(ourPortfolioButton);
        }

        public void ClickLegalMedia()
        {
            ClickElement(legalMediaButton);
        }

        public bool IsMenuButtonPresent()
        {
            return IsElementDisplayed(menuButton);
        }

    }
}
