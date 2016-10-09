using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Arcadia_test_task
{
    [Binding]
    public class EuromoneySteps
    {
        HomePage homePage;
        ManagementTeamPage managementTeamPage;

        [Given(@"I have opened start page")]
        public void GivenIHaveOpenedStartPage()
        {
            homePage = new HomePage();
            homePage.GoToHomePage();
        }
        
        [When(@"I click management team menu")]
        public void WhenIClickManagementTeamMenu()
        {
            homePage.ClickMenuButton();
            homePage.ClickWhoWeAreButton();
            homePage.ClickManagementTeamButton();
        }
        
        [Then(@"I see management team page is displayed correctly")]
        public void ThenISeeManagementTeamPageIsDisplayedCorrectly()
        {
            managementTeamPage = new ManagementTeamPage();
            Assert.IsTrue(managementTeamPage.IsTitlePresent());
        }

        [Then(@"The first image has a link")]
        public void ThenISeeTheFirstImageHasURL()
        {
            Assert.IsTrue(managementTeamPage.HasFirsImageLink());
        }
    }
}
