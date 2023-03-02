using OpenQA.Selenium;


namespace Core
{
    public class SearchGoogle
    {
        public static void SearcGoogle(IWebDriver driver, string searchText)
        {
            driver.Navigate().GoToUrl("https://smereka.com/");

            var googleInput = driver.FindElement(By.Name("q"));

            googleInput.SendKeys(searchText);
            googleInput.SendKeys(Keys.Enter);
        }
    }
}
