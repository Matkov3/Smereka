using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public  class CatalogTree : BasePage
    {
        protected override IWebElement Container => Driver.FindElement(By.CssSelector("#lay_right"));

        public string NamePageCatalog()
        {
            var nameTitle = Container.FindElement(By.CssSelector(".context_top")).Text;
            return nameTitle;
        }


        public void SelectTreeRecommendedTest()
        {
            var colections = Container.FindElements(By.CssSelector(".right .li a.add"));

            Random random = new Random();
            var index = random.Next(0, colections.Count);

            colections.ElementAt(index).Click();
               
        }

        public void SelectTree()
        {
            var treeColections = Container.FindElements(By.CssSelector(".li a.wrap"));

            var indexTree = new Random().Next(0, treeColections.Count);

            treeColections.ElementAt(indexTree).Click();

        }

        
    }
}
