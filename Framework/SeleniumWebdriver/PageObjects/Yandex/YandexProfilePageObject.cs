using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.Yandex
{
    public class YandexProfilePageObject : BasePage
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly By userButton = By.ClassName("PageHeader-user");
        private readonly By inboxButton = By.XPath("//a[@href = 'https://mail.yandex.by']");
        private readonly By subscriptionButton = By.ClassName("SubscriptionCard-statusText_offer");

        public YandexProfilePageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public YandexProfilePageObject OpenUserPopUp()
        {
            Waiter.WaitForClickableElement(userButton);
            WebDriver.FindElement(userButton).Click();

            _logger.Debug("Yandex user popup opened");

            return this;
        }

        public YandexInboxPageObject GoToInboxPage()
        {
            Waiter.WaitForClickableElement(inboxButton);
            WebDriver.FindElement(inboxButton).Click();

            _logger.Debug("Yandex inbox page opened");

            return new YandexInboxPageObject(WebDriver);
        }

        public YandexProfilePageObject WaitUntilLoad()
        {
            Waiter.WaitPageLoading();

            return this;
        }

        public YandexProfilePageObject WaitForSubscriptionButtonToAppear()
        {
            Waiter.WaitForVisibleElement(subscriptionButton);

            return this;
        }
    }
}
