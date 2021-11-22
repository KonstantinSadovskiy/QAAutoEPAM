using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.MailRu
{
    public class MailRuLetterConfirmationPageObject : BasePage
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly By letterConfirmationCloseButton = By.XPath("//span[@title = 'Закрыть']");

        public MailRuLetterConfirmationPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public MailRuInboxPageObject CloseConfirmationWindow()
        {
            Waiter.WaitForClickableElement(letterConfirmationCloseButton);
            WebDriver.FindElement(letterConfirmationCloseButton).Click();

            _logger.Debug("MailRu letter confirmation window closed");

            return new MailRuInboxPageObject(WebDriver);
        }
    }
}
