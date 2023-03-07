using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;


namespace Lib
{
    public abstract class BasePage
    {
        protected abstract IWebElement Container { get; }

        protected BasePage()
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(5)).Until(d =>
                Driver.ExecuteJavaScript<bool>("return document && document.readyState == 'complete'"));
        }

        protected static IWebDriver Driver
        { get
            {
                return ChromeDriverFactory.Driver;
            }
        }

    }
}
