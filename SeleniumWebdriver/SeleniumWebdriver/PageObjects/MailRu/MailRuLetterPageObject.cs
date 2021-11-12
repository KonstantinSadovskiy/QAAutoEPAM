using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.MailRu
{
    public class MailRuLetterPageObject : BasePage
    {
        private readonly By replyText = By.ClassName("html-parser");
        private readonly By profilePopUpButton = By.XPath("//div[@data-testid = 'whiteline-account']");
        private readonly By profileEditButton = By.XPath("//a[contains(@href, 'https://id.mail.ru/profile')][contains(@class, 'ph-item')]");

        public MailRuLetterPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public string GetReplyText()
        {
            Waiter.WaitForVisibleElement(replyText);
            return WebDriver.FindElement(replyText).Text;
        }

        public MailRuLetterPageObject OpenProfilePopUp()
        {
            Waiter.WaitForClickableElement(profilePopUpButton);
            WebDriver.FindElement(profilePopUpButton).Click();

            return this;
        }

        public MailRuProfileEditPageObject EnterProfileEditor()
        {
            Waiter.WaitForClickableElement(profileEditButton);
            WebDriver.FindElement(profileEditButton).Click();

            return new MailRuProfileEditPageObject(WebDriver);
        }
    }
}
