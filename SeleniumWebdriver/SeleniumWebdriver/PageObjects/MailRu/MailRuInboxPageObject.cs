using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.MailRu
{
    public class MailRuInboxPageObject : BasePage
    {
        private readonly By writeLetterMailRu = By.XPath("//span[@class = 'compose-button__txt']");
        private readonly By newNickReplyLetter = By.XPath("//span[text() = 'WebDriver - Test']");

        public MailRuInboxPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public MailRuSendLetterPageObject CreateLetter()
        {
            Waiter.WaitForClickableElement(writeLetterMailRu);
            WebDriver.FindElement(writeLetterMailRu).Click();

            return new MailRuSendLetterPageObject(WebDriver);
        }

        public MailRuLetterPageObject OpenReply()
        {
            Waiter.WaitForClickableElement(newNickReplyLetter);
            WebDriver.FindElement(newNickReplyLetter).Click();

            return new MailRuLetterPageObject(WebDriver);
        }
    }
}
