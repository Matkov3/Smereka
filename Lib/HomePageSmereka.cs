

using OpenQA.Selenium;

namespace Lib
{
    public class HomePageSmereka : BasePage
    {
        protected override IWebElement Container => Driver.FindElement(By.CssSelector("#lay_footer_wrap"));

        public string NamePage()
        {
            return Driver.Title;
        }


        
    }
}
