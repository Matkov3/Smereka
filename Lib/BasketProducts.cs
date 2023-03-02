using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Lib
{
    public class BasketProducts : BasePage
    {
        protected override IWebElement Container => Driver.FindElement(By.CssSelector(".basket_list"));


        public void PlaceOrder()
        {
            var waiter = new WebDriverWait(Driver, TimeSpan.FromSeconds(200));

            var timeWait = waiter.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".enough a.akabtn")));


            timeWait.Click();
        }

        public void LastPurshaseB()
        {
            Container.FindElement(By.CssSelector(".basket_list a.back")).Click();
        }

    }

    
}
