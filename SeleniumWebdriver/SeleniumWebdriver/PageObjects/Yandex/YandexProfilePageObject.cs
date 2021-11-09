using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.Yandex
{
    public class YandexProfilePageObject : BasePage
    {
        private readonly By userButton = By.XPath("//div[@class = 'PageHeader-user']");
        private readonly By inboxButton = By.XPath("//a[@href = 'https://mail.yandex.by']");

        public YandexProfilePageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public YandexProfilePageObject OpenUserPopUp()
        {
            Waiter.WaitForClickableElement(userButton);
            WebDriver.FindElement(userButton).Click();

            return this;
        }

        public YandexInboxPageObject GoToInboxPage()
        {
            Waiter.WaitForClickableElement(inboxButton);
            WebDriver.FindElement(inboxButton).Click();

            return new YandexInboxPageObject(WebDriver);
        }
    }
}
