using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.MailRu
{
    public class MailRuInboxPageObject : BasePage
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly By writeLetterMailRu = By.ClassName("compose-button__txt");
        private readonly By newNickReplyLetter = By.XPath("//span[text() = 'WebDriver - Test']");

        public MailRuInboxPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public MailRuSendLetterPageObject CreateLetter()
        {
            Waiter.WaitForClickableElement(writeLetterMailRu);
            WebDriver.FindElement(writeLetterMailRu).Click();

            _logger.Debug("MailRu letter creator opened");

            return new MailRuSendLetterPageObject(WebDriver);
        }

        public MailRuLetterPageObject OpenReply()
        {
            Waiter.WaitForClickableElement(newNickReplyLetter);
            WebDriver.FindElement(newNickReplyLetter).Click();

            _logger.Debug("MailRu reply opened");

            return new MailRuLetterPageObject(WebDriver);
        }
    }
}
