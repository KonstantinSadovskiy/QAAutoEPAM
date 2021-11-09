using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.MailRu
{
    public class MailRuProfileEditPageObject : BasePage
    {
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

            return this;
        }

        public MailRuProfileEditPageObject InputNewName(string newName)
        {
            Waiter.WaitForClickableElement(nameButton);
            WebDriver.FindElement(nameButton).Clear();
            WebDriver.FindElement(nameButton).SendKeys(newName);

            return this;
        }

        public MailRuProfileEditPageObject SaveChanges()
        {
            Waiter.WaitForClickableElement(saveButton);
            WebDriver.FindElement(saveButton).Click();

            return this;
        }

        public string GetNickname()
        {
            WebDriver.Navigate().Refresh();
            Waiter.WaitForClickableElement(nicknameButton);
            return WebDriver.FindElement(nicknameButton).GetAttribute("value");
        }
    }
}
