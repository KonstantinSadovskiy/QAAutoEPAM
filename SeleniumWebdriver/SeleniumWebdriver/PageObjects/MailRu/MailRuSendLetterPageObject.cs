using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.MailRu
{
    public class MailRuSendLetterPageObject : BasePage
    {
        private readonly By letterRecieverButton = By.XPath("//div[@data-name = 'to']/descendant::input[@type = 'text']");
        private readonly By letterThemeButton = By.XPath("//input[@name = 'Subject']");
        private readonly By letterTextButton = By.XPath("//div[@role = 'textbox']");
        private readonly By letterSendButton = By.XPath("//div[@class = 'compose-app__footer']/descendant::span[@data-title-shortcut = 'Ctrl+Enter']");

        public MailRuSendLetterPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public MailRuSendLetterPageObject InputRecieverMail(string email)
        {

            Waiter.WaitForClickableElement(letterRecieverButton);
            WebDriver.FindElement(letterRecieverButton).SendKeys(email);

            return this;
        }

        public MailRuSendLetterPageObject InputLetterTheme(string theme)
        {

            Waiter.WaitForClickableElement(letterThemeButton);
            WebDriver.FindElement(letterThemeButton).SendKeys(theme);

            return this;
        }

        public MailRuSendLetterPageObject InputLetterText(string text)
        {

            Waiter.WaitForClickableElement(letterTextButton);
            WebDriver.FindElement(letterTextButton).SendKeys(text);

            return this;
        }

        public MailRuLetterConfirmationPageObject SendLetter()
        {
            Waiter.WaitForClickableElement(letterSendButton);
            WebDriver.FindElement(letterSendButton).Click();

            return new MailRuLetterConfirmationPageObject(WebDriver);
        }
    }
}
