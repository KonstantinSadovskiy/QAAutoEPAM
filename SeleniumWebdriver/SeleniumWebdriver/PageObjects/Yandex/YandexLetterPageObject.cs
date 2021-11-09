using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.Yandex
{
    public class YandexLetterPageObject : BasePage
    {
        private readonly By letterText = By.XPath("//div[contains(@class, 'mail-Message-Body-Content')]");
        private readonly By letterReplyButton = By.XPath("//span[contains(@class, 'js-quick-reply-placeholder-single-reply')]");
        private readonly By letterInputReplyButton = By.XPath("//div[@role = 'textbox']");
        private readonly By letterSendReplyButton = By.XPath("//button[contains(@class, 'js-send-button')]");

        public YandexLetterPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public string GetLetterText()
        {
            Waiter.WaitForStaticElement(letterText);
            return WebDriver.FindElement(letterText).Text;
        }

        public YandexLetterPageObject InputLetterReply(string replyText)
        {
            Waiter.WaitForClickableElement(letterReplyButton);
            WebDriver.FindElement(letterReplyButton).Click();

            Waiter.WaitForClickableElement(letterInputReplyButton);
            WebDriver.FindElement(letterInputReplyButton).SendKeys(replyText);

            return this;
        }

        public YandexLetterPageObject SendReply()
        {
            Waiter.WaitForClickableElement(letterSendReplyButton);
            WebDriver.FindElement(letterSendReplyButton).Click();

            return this;
        }
    }
}
