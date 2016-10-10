using Arcadia_test_task.Pages;
using Arcadia_test_task.Pages.Economy;
using Arcadia_test_task.Pages.Iflr;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Arcadia_test_task
{
    [Binding]
    public class EuroMoneyPls
    {
        ManagementTeamPage managementTeamPage;
        EuroMoneyPlsHomePage homePage;
        LegalMediaPage legalMediaPage;
        IflrHomePage iflrHomePage;
        SubscriptionGroupsPage subscriptionGroupPage;
        CheckoutPage checkoutPage;

        static IWebDriver webDriver;

        #region [Hooks]

        [BeforeTestRun]
        public static void Before()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Size = new System.Drawing.Size(1024, 600);
        }

        [AfterTestRun]
        public static void After()
        {
            webDriver.Quit();
        }

        #endregion

        [When(@"I click Legal Media menu")]
        public void WhenIClickLegalMediaMenu()
        {
            homePage = new EuroMoneyPlsHomePage(webDriver);
            homePage.ClickMenuButton();
            homePage.ClickOurPortfolio();
            homePage.ClickLegalMedia();
            legalMediaPage = new LegalMediaPage(webDriver);
        }

        [Then(@"On Legal Media Page I can find Financial Law Review info")]
        public void ThenOnLegalMediaPageICanFindFinancialLawReviewInfo()
        {
            Assert.IsTrue(legalMediaPage.IsFinancialInfoDiaplyed());
        }

        [When(@"I Click visit IFLR button")]
        public void WhenIClickvisitIFLRbutton()
        {
            legalMediaPage.ClickFinancialLink();
            iflrHomePage = new IflrHomePage(webDriver);
        }

        [Then(@"IFLR main page opens in new tab")]
        public void ThenIflrMainPageOpensInNewTab()
        {
            iflrHomePage.GoToNextWindow();

            Assert.IsTrue(iflrHomePage.IsCurrentUrl(iflrHomePage.url));
        }

        [When(@"I click Subscribe button")]
        public void WhenIClickSubscribeButton()
        {
            iflrHomePage.ClickSubscribeButton();
            subscriptionGroupPage = new SubscriptionGroupsPage(webDriver);
        }

        [When(@"I can select Personal package")]
        public void WhenICanSelectPersonalPackage()
        {
            subscriptionGroupPage.ClickPersonaSelectButton();
            checkoutPage = new CheckoutPage(webDriver);
        }

        [Then(@"The prices are in Pounds")]
        public void ThenThePricesAreInPounds()
        {
            Assert.IsTrue(checkoutPage.AreSubscribePricesInPounds());
            Assert.IsTrue(checkoutPage.IsTotalPriceInPound());
        }

        [Then(@"12 Months package is pre-selected")]
        public void Then12MonthsPackageIsPreSelected()
        {
            Assert.IsTrue(checkoutPage.IsDefaultPeriodSet());
        }
        [Given(@"I have opened start page")]
        public void GivenIHaveOpenedStartPage()
        {

            homePage = new EuroMoneyPlsHomePage(webDriver);
            homePage.GoToHomePage();
        }

        [When(@"I click management team menu")]
        public void WhenIClickManagementTeamMenu()
        {
            homePage.ClickMenuButton();
            homePage.ClickWhoWeAreButton();
            homePage.ClickManagementTeamButton();
            managementTeamPage = new ManagementTeamPage(webDriver);
        }     
        
        [Then(@"I see management team page is displayed correctly")]
        public void ThenISeeManagementTeamPageIsDisplayedCorrectly()
        {
            Assert.IsTrue(managementTeamPage.IsTitlePresent());
            Assert.IsTrue(managementTeamPage.IsMenuButtonPresent());

        }

        [Then(@"The first image has a link")]
        public void ThenISeeTheFirstImageHasURL()
        {
            Assert.IsTrue(managementTeamPage.HasFirsImageLink());
        }
    }
}
