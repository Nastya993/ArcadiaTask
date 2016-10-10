using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcadia_test_task.Pages.Iflr
{
    class CheckoutPage : BaseClass
    {
        By twelveMonths = By.XPath("//div[@id='ctl00_MainContent_baseProduct_SubscriptionProduct_SubscriptionsRepeater_ctl00_divRow']");
        By subscribePrices = By.XPath("//div[@id='ctl00_MainContent_baseProduct_divColMain']//h5");
        By totalPrice = By.XPath("//span[@class='totpriceval']");
        public bool IsDefaultPeriodSet()
        {
            return IsElementActive(twelveMonths);
        }
        public bool AreSubscribePricesInPounds()
        {
            bool result = true;
            ReadOnlyCollection <IWebElement> prices = FindElements(subscribePrices);
            foreach(IWebElement price in prices)
            {
                result =  
                    price.Text
                    .Contains("£") && result;
            }
            return result;
        }

        public bool IsTotalPriceInPound()
        {
            return FindElement(totalPrice).Text.Contains("£");
        }

    }
}
