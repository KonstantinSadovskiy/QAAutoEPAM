using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.MailRu
{
    public class MailRuAuthorizationEmailPageObject : BasePage
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private const string _url = "https://account.mail.ru/login";

        private readonly By authorizationEmailInputButton = By.XPath("//*[@data-test-id = 'username-formfield']//input[@type='text']");
        private readonly By authorizationEmailSubmitButton = By.XPath("//*[@data-test-id = 'next-button']");
        private readonly By authorizationDomainSelectButton = By.XPath("//div[@data-test-id = 'domain-select']");
        private readonly By emptyEmailText = By.XPath("//small[@data-test-id = 'required']");
        private readonly By wrongEmailText = By.XPath("//small[@data-test-id = 'accountNotRegistered']");

        public MailRuAuthorizationEmailPageObject(IWebDriver webDriver) : base(webDriver)
        {
            WebDriver.Navigate().GoToUrl(_url);
        }

        public MailRuAuthorizationEmailPageObject InputEmail(string email)
        {
            Waiter.WaitForClickableElement(authorizationDomainSelectButton);
            WebDriver.FindElement(authorizationEmailInputButton).Clear();
            WebDriver.FindElement(authorizationEmailInputButton).SendKeys(email);

            _logger.Debug("MailRu mail inputed");

            return this;
        }

        public MailRuAuthorizationPasswordPageObject SubmitEmail()
        {
            Waiter.WaitForClickableElement(authorizationEmailSubmitButton);
            WebDriver.FindElement(authorizationEmailSubmitButton).Click();

            _logger.Debug("MailRu mail submited");

            return new MailRuAuthorizationPasswordPageObject(WebDriver);
        }

        public MailRuAuthorizationEmailPageObject SubmitEmailExpectedError()
        {
            Waiter.WaitForClickableElement(authorizationEmailSubmitButton);
            WebDriver.FindElement(authorizationEmailSubmitButton).Click();

            _logger.Debug("MailRu mail submited");

            return this;
        }

        public string GetEmptyEmailMessageText()
        {
            Waiter.WaitForVisibleElement(emptyEmailText);

            _logger.Debug("MailRu empty email message recieved");

            return WebDriver.FindElement(emptyEmailText).Text;
        }

        public string GetWrongEmailMessageText()
        {
            Waiter.WaitForVisibleElement(wrongEmailText);

            _logger.Debug("MailRu wrong email message recieved");

            return WebDriver.FindElement(wrongEmailText).Text;
        }
    }
}
