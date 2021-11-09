using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects.MailRu
{
    public class MailRuMainPageObject : BasePage
    {
        private readonly By profilePopUpButton = By.XPath("//div[@data-testid = 'whiteline-account']");
        private readonly By profileName = By.XPath("//div[contains(@class, 'ph-name')]");

        public MailRuMainPageObject(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        public MailRuMainPageObject OpenProfilePopUp()
        {
            Waiter.WaitForClickableElement(profilePopUpButton);
            WebDriver.FindElement(profilePopUpButton).Click();

            return this;
        }

        public string GetName()
        {
            Waiter.WaitForStaticElement(profileName);
            return WebDriver.FindElement(profileName).Text;
        }
    }
}
