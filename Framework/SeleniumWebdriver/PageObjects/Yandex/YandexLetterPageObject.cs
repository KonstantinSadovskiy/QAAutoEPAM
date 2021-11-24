using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.Yandex
{
    public class YandexLetterPageObject : BasePage
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly By letterText = By.XPath("//div[contains(@class, 'mail-Message-Body-Content')]");
        private readonly By letterReplySuccess = By.ClassName("ns-view-quick-reply-done-success");
        private readonly By letterReplyButton = By.ClassName("js-quick-reply-placeholder-single-reply");
        private readonly By letterInputReplyButton = By.XPath("//div[@role = 'textbox']");
        private readonly By letterSendReplyButton = By.ClassName("js-send-button");

        public YandexLetterPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public string GetLetterText()
        {
            Waiter.WaitForVisibleElement(letterText);

            _logger.Debug("Yandex letter text parsed");

            return WebDriver.FindElement(letterText).Text;
        }

        public YandexLetterPageObject InputLetterReply(string replyText)
        {
            Waiter.WaitForClickableElement(letterReplyButton);
            WebDriver.FindElement(letterReplyButton).Click();

            Waiter.WaitForClickableElement(letterInputReplyButton);
            WebDriver.FindElement(letterInputReplyButton).SendKeys(replyText);

            _logger.Debug("Yandex letter reply inputed");

            return this;
        }

        public YandexLetterPageObject SendReply()
        {
            Waiter.WaitForClickableElement(letterSendReplyButton);
            WebDriver.FindElement(letterSendReplyButton).Click();

            _logger.Debug("Yandex reply sent");

            return this;
        }

        public YandexLetterPageObject ConfirmReplySuccess()
        {
            if (TestContext.Parameters["browser"] == "firefox")
            {
                Waiter.WaitForVisibleElementToDisappear(letterReplySuccess);
            }
            else
            {
                Waiter.WaitForVisibleElement(letterReplySuccess);
            }


            _logger.Debug("Yandex reply sending confirmed");

            return this;
        }

        public YandexLetterPageObject WaitUntilLoad()
        {
            Waiter.WaitPageLoading();

            return this;
        }
    }
}
