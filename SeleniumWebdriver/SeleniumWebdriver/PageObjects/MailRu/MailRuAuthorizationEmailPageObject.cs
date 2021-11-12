using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.MailRu
{
    public class MailRuAuthorizationEmailPageObject : BasePage
    {
        private const string _url = "https://account.mail.ru/login";

        private readonly By authorizationEmailInputButton = By.XPath("//*[@data-test-id = 'username-formfield']//input[@type='text']");
        private readonly By authorizationEmailSubmitButton = By.XPath("//*[@data-test-id = 'next-button']");
        private readonly By emptyEmailText = By.XPath("//small[@data-test-id = 'required']");
        private readonly By wrongEmailText = By.XPath("//small[@data-test-id = 'accountNotRegistered']");

        public MailRuAuthorizationEmailPageObject(IWebDriver webDriver) : base(webDriver)
        {
            WebDriver.Navigate().GoToUrl(_url);
        }

        public MailRuAuthorizationEmailPageObject InputEmail(string email)
        {
            Waiter.WaitForClickableElement(authorizationEmailInputButton);
            WebDriver.FindElement(authorizationEmailInputButton).SendKeys(email);

            return this;
        }

        public MailRuAuthorizationPasswordPageObject SubmitEmail()
        {
            Waiter.WaitForClickableElement(authorizationEmailSubmitButton);
            WebDriver.FindElement(authorizationEmailSubmitButton).Click();

            return new MailRuAuthorizationPasswordPageObject(WebDriver);
        }

        public MailRuAuthorizationEmailPageObject SubmitEmailExpectedError()
        {
            Waiter.WaitForClickableElement(authorizationEmailSubmitButton);
            WebDriver.FindElement(authorizationEmailSubmitButton).Click();

            return this;
        }

        public string GetEmptyEmailMessageText()
        {
            Waiter.WaitForVisibleElement(emptyEmailText);
            return WebDriver.FindElement(emptyEmailText).Text;
        }

        public string GetWrongEmailMessageText()
        {
            Waiter.WaitForVisibleElement(wrongEmailText);
            return WebDriver.FindElement(wrongEmailText).Text;
        }
    }
}
