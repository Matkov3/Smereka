using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions; 

namespace Lib
{
    public class Basket : BasePage
    {
        protected override IWebElement Container => Driver.FindElement(By.CssSelector("#lay_header"));

        public void BasketClick()
        {
            var waite = new WebDriverWait(Driver, TimeSpan.FromSeconds(200));

            var clickLink = waite.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div.info div.full a.go")));
            clickLink.Click();
        }




    }

   
}
