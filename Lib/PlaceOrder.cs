using Lib.PageComponents;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Text.Json;
using System.Xml.Linq;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;


namespace Lib
{
    public class PlaceOrder : BasePage
    {
        protected override IWebElement Container => Driver.FindElement(By.CssSelector("#lay_content"));

        private IWebElement NameInput => Container.FindElement(By.CssSelector("input[name='last_name']"));
        private IWebElement SurmaneInput => Container.FindElement(By.CssSelector("input[name='first_name']"));
        private IWebElement MiddleInput => Container.FindElement(By.CssSelector("input[name='middle_name']"));
        private IWebElement AdressInput => Container.FindElement(By.CssSelector("input[name='address']"));
        private IWebElement TelefonInput => Container.FindElement(By.CssSelector("input[name='telefon']"));
        private IWebElement EmailInput => Container.FindElement(By.CssSelector("input[name='email']"));
        private IWebElement CommentsInput => Container.FindElement(By.CssSelector("textarea[name='message']"));

        private SelectElement OblastSelect => new SelectElement(Container.FindElement(By.CssSelector("div.select_address .region select")));
        private SelectElement GorodSelect => new SelectElement(Container.FindElement(By.CssSelector("div.select_address .town select")));
        private SelectElement Novaya_PochtaSelect => new SelectElement(Container.FindElement(By.CssSelector("div.select_address .warehouse select")));

        

        public void FillCustomer()
        {
            var filePath = $"{Environment.CurrentDirectory}\\Data\\InformationCustomers.json";
            
            InformationOfCustomer customerInfo;

            if (File.Exists(filePath))
            {
                var jsonText = File.ReadAllText($"{Environment.CurrentDirectory}\\Data\\InformationCustomers.json");
                customerInfo = JsonSerializer.Deserialize<InformationOfCustomer>(jsonText);
            }
            else
            {
                throw new FileNotFoundException($"File on path {filePath} not found.");
            }

            
            NameInput.SendKeys(customerInfo.Name);
            SurmaneInput.SendKeys(customerInfo.Surname);
            MiddleInput.SendKeys(customerInfo.MiddleName);
            TelefonInput.SendKeys(customerInfo.TelefonNumber);
            EmailInput.SendKeys(customerInfo.E_mail);
            CommentsInput.SendKeys(customerInfo.Сomments);
            AdressInput.SendKeys(Keys.Tab);
            OblastSelect.SelectByText(customerInfo.Oblast);
            Thread.Sleep(TimeSpan.FromSeconds(7));

            GorodSelect.SelectByText(customerInfo.Gorod);
            Thread.Sleep(TimeSpan.FromSeconds(7));

            Novaya_PochtaSelect.SelectByText(customerInfo.Novaya_Pochta);
            Thread.Sleep(TimeSpan.FromSeconds(7));

           
        }

        public void ClickOrderSubmit()
        {
            Container.FindElement(By.CssSelector(".wrap_submit input.submit")).Click();
        }

        public void LastPurshasPO()
        {
            var waiter = new WebDriverWait(Driver, TimeSpan.FromSeconds(100));

            var timeWait = waiter.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a.back")));

            timeWait.Click();
        }
    }
}
