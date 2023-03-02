using Core;
using OpenQA.Selenium;


namespace Lib
{
    public abstract class BasePage
    {
        protected abstract IWebElement Container { get; }

        protected static IWebDriver Driver
        { get
            {
                return ChromeDriverFactory.Driver;
            }
        }

    }
}
