using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.Yandex
{
    public class YandexLoginNickPageObject : BasePage
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private const string _url = "https://passport.yandex.by/";

        private readonly By loginButton = By.Id("passp-field-login");
        private readonly By nextButton = By.Id("passp:sign-in");

        public YandexLoginNickPageObject(IWebDriver webDriver) : base(webDriver)
        {
            WebDriver.Navigate().GoToUrl(_url);
        }

        public YandexLoginNickPageObject InputNick(string email)
        {
            Waiter.WaitForClickableElement(loginButton);
            WebDriver.FindElement(loginButton).SendKeys(email);

            _logger.Debug("Yandex nick inputed");

            return this;
        }

        public YandexLoginPasswordPageObject SubmitNick()
        {
            Waiter.WaitForClickableElement(nextButton);
            WebDriver.FindElement(nextButton).Click();

            _logger.Debug("Yandex nick submited");

            return new YandexLoginPasswordPageObject(WebDriver);
        }
    }
}
