using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.Yandex
{
     public class YandexLoginPasswordPageObject : BasePage
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly By passwordButton = By.Id("passp-field-passwd");
        private readonly By signinButton = By.Id("passp:sign-in");

        public YandexLoginPasswordPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public YandexLoginPasswordPageObject InputPassword(string password)
        {
            Waiter.WaitForClickableElement(passwordButton);
            WebDriver.FindElement(passwordButton).SendKeys(password);

            _logger.Debug("Yandex password inputed");

            return this;
        }

        public YandexProfilePageObject SubmitPassword()
        {
            Waiter.WaitForClickableElement(signinButton);
            WebDriver.FindElement(signinButton).Click();

            _logger.Debug("Yandex password submited");

            return new YandexProfilePageObject(WebDriver);
        }
    }
}
