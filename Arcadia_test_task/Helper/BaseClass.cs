using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcadia_test_task
{
    public class BaseClass
    {
        public IWebDriver WebDriver { get; private set; }

        private TimeSpan TIMEOUT = new TimeSpan(0, 0, 30);

        public BaseClass(IWebDriver driver)
        {
            WebDriver = driver;
        }

        public void GoToURL(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }

        public bool IsCurrentUrl(string url)
        {
            return (WebDriver.Url.Contains(url));
        }

        public bool IsElementActive(By element)
        {
            IWebElement webElemnt = FindElement(element);
            bool attributeClass = false;
            try
            {
                attributeClass = webElemnt.GetAttribute("class").Contains("active");
            }
            catch 
            {
                return false;
            }
            return attributeClass;
        }

        protected IWebElement FindElement(By element)
        {
            WaitForWebElement(element);
            return  WebDriver.FindElement(element);
        }

        protected void WaitForWebElement(By element)
        {
            (new WebDriverWait(WebDriver, TIMEOUT)).Until(ExpectedConditions.ElementToBeClickable(element));      
        }

        protected void ClickElement(By element)
        {
            FindElement(element).Click();
        }

        protected void ClickElementInElement(By elementParent, By elementChild)
        {
            FindElement(elementParent).FindElement(elementChild).Click();
        }

        protected IWebElement GetParent(IWebElement element)
        {
            return element.FindElement(By.XPath(".."));
        }

        protected IWebElement GetFirstElement(By element)
        {
            return FindElements(element)[0];
        }

        protected ReadOnlyCollection<IWebElement> FindElements(By element)
        {
            WaitForWebElement(element);
            return WebDriver.FindElements(element);
        }

        protected bool HasParentAttibute(By childElement, string attribute)
        {
            string ret = GetParent(GetFirstElement(childElement)).GetAttribute(attribute);
            if (ret != null)
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

        public void GoToNextWindow()
        {
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles.Last());
        }
    }
}
