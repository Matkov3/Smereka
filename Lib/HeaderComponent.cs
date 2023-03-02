using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class HeaderComponent : BasePage
    {
        protected override IWebElement Container => Driver.FindElement(By.CssSelector("#lay_header"));

        private IWebElement MenuCatalog => Container.FindElement(By.CssSelector("div.menu_catalog"));

        public void SelectMenu(string menulevel_1, string menulevel_2)
        {
            MenuCatalog.FindElements(By.CssSelector("li.plus")).First(e => e.Text == menulevel_1).Click();

            MenuCatalog.FindElements(By.CssSelector("a")).First(e => e.Text == menulevel_2).Click();
        }

    }
}
;