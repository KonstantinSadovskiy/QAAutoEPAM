using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.MailRu
{
    public class MailRuLetterPageObject : BasePage
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly By replyText = By.ClassName("html-parser");
        private readonly By profilePopUpButton = By.XPath("//div[@data-testid = 'whiteline-account']");
        private readonly By profileEditButton = By.XPath("//a[contains(@href, 'https://id.mail.ru/profile')][contains(@class, 'ph-item')]");

        public MailRuLetterPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public string GetReplyText()
        {
            Waiter.WaitForVisibleElement(replyText);

            _logger.Debug("MailRu reply text parsed");

            return WebDriver.FindElement(replyText).Text;
        }

        public MailRuLetterPageObject OpenProfilePopUp()
        {
            Waiter.WaitForClickableElement(profilePopUpButton);
            WebDriver.FindElement(profilePopUpButton).Click();

            _logger.Debug("MailRu profile popup opened");

            return this;
        }

        public MailRuProfileEditPageObject EnterProfileEditor()
        {
            Waiter.WaitForClickableElement(profileEditButton);
            WebDriver.FindElement(profileEditButton).Click();

            _logger.Debug("MailRu profile editor entered");

            return new MailRuProfileEditPageObject(WebDriver);
        }
    }
}
