using OpenQA.Selenium;

namespace SeleniumWebdriver.PageObjects
{
    public abstract class BasePage
    {
        public IWebDriver WebDriver { get; set; }

        private readonly int runOutTime = 10;

        protected BasePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
            Waiter.WebDriver = WebDriver;
            Waiter.runOutTime = runOutTime;
        }
    }
}
