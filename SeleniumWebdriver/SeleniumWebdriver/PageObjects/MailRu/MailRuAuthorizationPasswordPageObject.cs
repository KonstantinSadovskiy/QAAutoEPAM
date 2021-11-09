using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.MailRu
{
    public class MailRuAuthorizationPasswordPageObject : BasePage
    {
        private readonly By authorizationPasswordInputButton = By.XPath("//div[@class = 'login-row password']/descendant::input[@type = 'password']");
        private readonly By authorizationPasswordSubmitButton = By.XPath("//*[@data-test-id = 'submit-button']");
        private readonly By wrongPasswordText = By.XPath("//div[@data-test-id = 'error-footer-text']");

        public MailRuAuthorizationPasswordPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public MailRuAuthorizationPasswordPageObject InputPassword(string password)
        {
            Waiter.WaitForClickableElement(authorizationPasswordInputButton);
            WebDriver.FindElement(authorizationPasswordInputButton).SendKeys(password);

            return this;
        }

        public MailRuInboxPageObject SubmitPassword()
        {
            Waiter.WaitForClickableElement(authorizationPasswordSubmitButton);
            WebDriver.FindElement(authorizationPasswordSubmitButton).Click();

            return new MailRuInboxPageObject(WebDriver);
        }

        public MailRuAuthorizationPasswordPageObject SubmitPasswordExpectedError()
        {
            Waiter.WaitForClickableElement(authorizationPasswordSubmitButton);
            WebDriver.FindElement(authorizationPasswordSubmitButton).Click();

            return this;
        }

        public string GetWrongPasswordMessageText()
        {
            Waiter.WaitForStaticElement(wrongPasswordText);
            return WebDriver.FindElement(wrongPasswordText).Text;
        }
    }
}
