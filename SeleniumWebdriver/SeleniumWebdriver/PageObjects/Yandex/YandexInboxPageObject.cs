using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.Yandex
{
    public class YandexInboxPageObject : BasePage
    {
        public const string letterTheme = "WebDriver - Test";
        private readonly By spamTab = By.XPath("//a[@href = '#spam']");
        private readonly By newestUnreadLetterButton = By.XPath($"//span[contains(@class, 'state_toRead')]/following::div[1]/descendant::*[contains(text(), '{letterTheme}')]");
        private readonly By newestLetterButton = By.XPath($"//*[contains(text(), '{letterTheme}')]");

        public YandexInboxPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public YandexInboxPageObject OpenSpamTab()
        {
            Waiter.WaitForClickableElement(spamTab);
            WebDriver.FindElement(spamTab).Click();

            return this;
        }

        public YandexLetterPageObject OpenNewestUnreadLetter()
        {
            Waiter.WaitForClickableElement(newestUnreadLetterButton);
            WebDriver.FindElement(newestUnreadLetterButton).Click();

            return new YandexLetterPageObject(WebDriver);
        }

        public YandexLetterPageObject OpenNewestLetter()
        {
            Waiter.WaitForClickableElement(newestLetterButton);
            WebDriver.FindElement(newestLetterButton).Click();

            return new YandexLetterPageObject(WebDriver);
        }
    }
}
