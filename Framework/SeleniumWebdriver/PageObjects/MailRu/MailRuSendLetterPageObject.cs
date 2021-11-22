using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.MailRu
{
    public class MailRuSendLetterPageObject : BasePage
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly By letterRecieverButton = By.XPath("//div[@data-name = 'to']//input[@type = 'text']");
        private readonly By letterThemeButton = By.Name("Subject");
        private readonly By letterTextButton = By.XPath("//div[@role = 'textbox']");
        private readonly By letterSendButton = By.XPath("//div[@class = 'compose-app__footer']//span[@data-title-shortcut = 'Ctrl+Enter']");

        public MailRuSendLetterPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public MailRuSendLetterPageObject InputRecieverMail(string email)
        {

            Waiter.WaitForClickableElement(letterRecieverButton);
            WebDriver.FindElement(letterRecieverButton).SendKeys(email);

            _logger.Debug("MailRu reciever mail inputed");

            return this;
        }

        public MailRuSendLetterPageObject InputLetterTheme(string theme)
        {

            Waiter.WaitForClickableElement(letterThemeButton);
            WebDriver.FindElement(letterThemeButton).SendKeys(theme);

            _logger.Debug("MailRu letter theme inputed");

            return this;
        }

        public MailRuSendLetterPageObject InputLetterText(string text)
        {

            Waiter.WaitForClickableElement(letterTextButton);
            WebDriver.FindElement(letterTextButton).SendKeys(text);

            _logger.Debug("MailRu letter text inputed");

            return this;
        }

        public MailRuLetterConfirmationPageObject SendLetter()
        {
            Waiter.WaitForClickableElement(letterSendButton);
            WebDriver.FindElement(letterSendButton).Click();

            _logger.Debug("MailRu letter sent");

            return new MailRuLetterConfirmationPageObject(WebDriver);
        }
    }
}
