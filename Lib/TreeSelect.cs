using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Lib
{
    public class TreeSelect : BasePage
    {
        protected override IWebElement Container => Driver.FindElement(By.CssSelector("#lay_right"));

        public void TreeClick(string price)
        {
            Container.FindElement(By.CssSelector($"div.items div.li a[class*='price:{price}']")).Click();            
        }

        public void TreeDel()
        {
            var waiter = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            var deletelink = waiter.Until(ExpectedConditions.ElementExists(By.CssSelector("div.in[style*='block'] a.del")));

            deletelink.Click();
        }

        public List<string> Prices()
        {
            return Container.FindElements(By.CssSelector("div.price")).Select(x => x.Text.Split(" ")[0]).ToList();
        }
    }
}
