using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.MailRu
{
    public class MailRuProfileEditPageObject : BasePage
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly By nameButton = By.XPath("//input[@data-test-id = 'firstname-field-input']");
        private readonly By nicknameButton = By.XPath("//input[@data-test-id = 'nickname-field-input']");
        private readonly By saveButton = By.XPath("//button[@data-test-id = 'save-button']");

        public MailRuProfileEditPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public MailRuProfileEditPageObject InputNewNick(string newNickname)
        {
            Waiter.WaitForClickableElement(nicknameButton);
            WebDriver.FindElement(nicknameButton).Clear();
            WebDriver.FindElement(nicknameButton).SendKeys(newNickname);

            _logger.Debug("MailRu new nick inputed");

            return this;
        }

        public MailRuProfileEditPageObject InputNewName(string newName)
        {
            Waiter.WaitForClickableElement(nameButton);
            WebDriver.FindElement(nameButton).Clear();
            WebDriver.FindElement(nameButton).SendKeys(newName);

            _logger.Debug("MailRu new name inputed");

            return this;
        }

        public MailRuProfileEditPageObject SaveChanges()
        {
            Waiter.WaitForClickableElement(saveButton);
            WebDriver.FindElement(saveButton).Click();

            _logger.Debug("MailRu profile changes saved");

            return this;
        }

        public string GetNickname()
        {
            WebDriver.Navigate().Refresh();
            Waiter.WaitForClickableElement(nicknameButton);

            _logger.Debug("MailRu profile nick parsed");

            return WebDriver.FindElement(nicknameButton).GetAttribute("value");
        }
    }
}
