using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.MailRu
{
    public class MailRuMainPageObject : BasePage
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly By profilePopUpButton = By.XPath("//div[@data-testid = 'whiteline-account']");
        private readonly By profileName = By.ClassName("ph-name");

        public MailRuMainPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public MailRuMainPageObject OpenProfilePopUp()
        {
            Waiter.WaitForClickableElement(profilePopUpButton);
            WebDriver.FindElement(profilePopUpButton).Click();

            _logger.Debug("MailRu profile popup opened");

            return this;
        }

        public string GetName()
        {
            Waiter.WaitForVisibleElement(profileName);

            _logger.Debug("MailRu account name parsed");

            return WebDriver.FindElement(profileName).Text;
        }
    }
}
