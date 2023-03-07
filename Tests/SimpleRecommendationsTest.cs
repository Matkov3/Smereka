using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V108.Page;

namespace Tests
{
    internal class SimpleRecommendationsTest : BaseTest
    {
        [Test]
        public void RecommendationTest()
        {
            Driver.Navigate().GoToUrl("https://smereka.com/");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            new HomePageSmereka().ScrollToRecommendedBlock();
            Thread.Sleep(TimeSpan.FromSeconds(3));

            new HomePageSmereka().ChooseTree();

            new CatalogTree().SelectTreeRecommendedTest();

        }

    }
}