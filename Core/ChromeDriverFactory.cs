using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace Core
{
    public class ChromeDriverFactory
    {
        public static IWebDriver Driver;

        public static IWebDriver CreateChrome()
        {

            var chromeService = ChromeDriverService.CreateDefaultService();
            chromeService.HideCommandPromptWindow = true;
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            chromeOptions.AddArgument("incognito");
            chromeOptions.AddArgument("--disable-popup-blocking");
            chromeOptions.AddArgument("--ignore-certificate-errors");
            chromeOptions.AddArgument("--disable-default-apps");

            var driver = new ChromeDriver(chromeService, chromeOptions);


            return driver;
        }
    }
}
