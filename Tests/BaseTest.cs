using Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Tests
{
    public class BaseTest
    {
        protected static IWebDriver Driver => ChromeDriverFactory.Driver;
        
        [OneTimeSetUp]
        public void BeforeTests()
        {
            ChromeDriverFactory.Driver = ChromeDriverFactory.CreateChrome();
        }

        [OneTimeTearDown]
        public void AfterTests()
        {
           ChromeDriverFactory.Driver.Dispose();
        }

    }
}
