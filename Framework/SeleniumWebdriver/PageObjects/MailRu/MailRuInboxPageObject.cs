using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.MailRu
{
    public class MailRuInboxPageObject : BasePage
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly By writeLetterMailRuButton = By.ClassName("compose-button__wrapper");
        private readonly By newNickReplyLetterButton = By.XPath("//span[text() = 'WebDriver - Test']");

        public MailRuInboxPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public MailRuSendLetterPageObject CreateLetter()
        {
            Waiter.WaitForClickableElement(writeLetterMailRuButton);
            WebDriver.FindElement(writeLetterMailRuButton).Click();

            _logger.Debug("MailRu letter creator opened");

            return new MailRuSendLetterPageObject(WebDriver);
        }

        public MailRuLetterPageObject OpenReply()
        {
            Waiter.WaitForClickableElement(newNickReplyLetterButton);
            WebDriver.FindElement(newNickReplyLetterButton).Click();

            _logger.Debug("MailRu reply opened");

            return new MailRuLetterPageObject(WebDriver);
        }
    }
}
