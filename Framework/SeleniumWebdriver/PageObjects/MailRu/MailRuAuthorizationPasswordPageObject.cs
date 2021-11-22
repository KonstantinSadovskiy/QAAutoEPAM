using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.MailRu
{
    public class MailRuAuthorizationPasswordPageObject : BasePage
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly By authorizationPasswordInputButton = By.XPath("//div[@class = 'login-row password']//input[@type = 'password']");
        private readonly By authorizationPasswordSubmitButton = By.XPath("//*[@data-test-id = 'submit-button']");
        private readonly By wrongPasswordText = By.XPath("//div[@data-test-id = 'error-footer-text']");

        public MailRuAuthorizationPasswordPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public MailRuAuthorizationPasswordPageObject InputPassword(string password)
        {
            Waiter.WaitForClickableElement(authorizationPasswordInputButton);
            WebDriver.FindElement(authorizationPasswordInputButton).SendKeys(password);

            _logger.Debug("MailRu passoword inputed");

            return this;
        }

        public MailRuInboxPageObject SubmitPassword()
        {
            Waiter.WaitForClickableElement(authorizationPasswordSubmitButton);
            WebDriver.FindElement(authorizationPasswordSubmitButton).Click();

            _logger.Debug("MailRu password submitted");

            return new MailRuInboxPageObject(WebDriver);
        }

        public MailRuAuthorizationPasswordPageObject SubmitPasswordExpectedError()
        {
            Waiter.WaitForClickableElement(authorizationPasswordSubmitButton);
            WebDriver.FindElement(authorizationPasswordSubmitButton).Click();

            _logger.Debug("MailRu password submitted");

            return this;
        }

        public string GetWrongPasswordMessageText()
        {
            Waiter.WaitForVisibleElement(wrongPasswordText);

            _logger.Debug("MailRu wrong password message recieved");

            return WebDriver.FindElement(wrongPasswordText).Text;
        }
    }
}
