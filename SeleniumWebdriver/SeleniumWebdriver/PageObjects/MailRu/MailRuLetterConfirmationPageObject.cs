using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.MailRu
{
    public class MailRuLetterConfirmationPageObject : BasePage
    {
        private readonly By letterConfirmationCloseButton = By.XPath("//span[@title = 'Закрыть']");

        public MailRuLetterConfirmationPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public MailRuInboxPageObject CloseConfirmationWindow()
        {
            Waiter.WaitForClickableElement(letterConfirmationCloseButton);
            WebDriver.FindElement(letterConfirmationCloseButton).Click();

            return new MailRuInboxPageObject(WebDriver);
        }
    }
}
