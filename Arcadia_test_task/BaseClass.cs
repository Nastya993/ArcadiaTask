using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcadia_test_task
{
    public class BaseClass
    {
        public static IWebDriver driver;
        private TimeSpan TIMEOUT = new TimeSpan(0,0,30);
        public string BASEURL = "http://www.euromoneyplc.com/";

        public void GoToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        protected IWebElement FindElement(By element)
        {            
            (new WebDriverWait(driver,TIMEOUT)).Until(ExpectedConditions.ElementToBeClickable(element));        
            IWebElement webElement = driver.FindElement(element);
            return webElement;
        }

        protected void ClickElement(By element)
        {
            FindElement(element).Click();           
        }

        public bool IsElementDisplayed(By element)
        {
            try
            {
                FindElement(element);
            }
            catch { return false; }
            return true;
        }
    }
}
