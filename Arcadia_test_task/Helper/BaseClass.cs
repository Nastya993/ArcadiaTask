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
        /*{
            get { return driver;}
            set { driver = value;}        
        }*/
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

        protected IWebElement GetParent (IWebElement element)
        {
            return element.FindElement(By.XPath(".."));
        }

        protected IWebElement GetFirstElement(By element)
        {
            return driver.FindElements(element)[0];
        }

        protected bool HasParentAttibute(By childElement, string attribute)
        {
            string ret = GetParent(GetFirstElement(childElement)).GetAttribute(attribute);    
            if (ret!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
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
