using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.Yandex
{
    public class YandexInboxPageObject : BasePage
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        public const string letterTheme = "WebDriver - Test";

        private readonly By spamTabPopUp = By.XPath("//div[contains(@class, 'SpamBanner__overlay')]");
        private readonly By spamTabButton = By.XPath("//a[@href = '#spam']");
        private readonly By newestUnreadLetterButton = By.XPath($"//span[contains(@class, 'state_toRead')]/following::div[1]//*[contains(text(), '{letterTheme}')]");
        private readonly By newestLetterButton = By.XPath($"//*[contains(text(), '{letterTheme}')]");

        public YandexInboxPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public YandexInboxPageObject OpenSpamTab()
        {
            Waiter.WaitForClickableElement(spamTabButton);
            WebDriver.FindElement(spamTabButton).Click();

            _logger.Debug("Yandex spam tab opened");

            return this;
        }

        public YandexLetterPageObject OpenNewestUnreadLetter()
        {
            Waiter.WaitForVisibleElement(spamTabPopUp);
            Waiter.WaitForClickableElement(newestUnreadLetterButton);
            WebDriver.FindElement(newestUnreadLetterButton).Click();

            _logger.Debug("Yandex newest unread letter opened");

            return new YandexLetterPageObject(WebDriver);
        }

        public YandexLetterPageObject OpenNewestLetter()
        {
            Waiter.WaitForVisibleElement(spamTabPopUp);
            Waiter.WaitForClickableElement(newestLetterButton);
            WebDriver.FindElement(newestLetterButton).Click();

            _logger.Debug("Yandex newest letter opened");

            return new YandexLetterPageObject(WebDriver);
        }
    }
}
