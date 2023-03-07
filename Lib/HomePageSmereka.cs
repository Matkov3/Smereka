

using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Lib
{
    public class HomePageSmereka : BasePage
    {
        protected override IWebElement Container => Driver.FindElement(By.CssSelector("#lay_footer_wrap"));

        private IWebElement RecommendedBlock =>
            Container.FindElement(By.CssSelector("div.tabcont.hit"));

        public string NamePage()
        {
            return Driver.Title;
        }

        public HomePageSmereka ScrollToRecommendedBlock()
        {
            Driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", RecommendedBlock);

            return this;
        }

        public void ChooseTree()
        {
            var colectionTree = Container.FindElements(By.CssSelector("div.tabcont #carou_hit .list .li"));
            var index = new Random().Next(1, colectionTree.Count-3);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            colectionTree.ElementAt(index).Click();
        }
    }
}
