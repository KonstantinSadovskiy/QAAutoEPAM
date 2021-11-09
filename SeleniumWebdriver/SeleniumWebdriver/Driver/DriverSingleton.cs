using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumWebdriver.Driver
{
    public class DriverSingleton
    {
        private static IWebDriver _webDriver;

        public DriverSingleton() { }

        public static IWebDriver GetDriver()
        {
            if(_webDriver == null)
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                _webDriver = new ChromeDriver();
            }

            return _webDriver; 
        }

        public static void CloseDriver()
        {
            _webDriver.Quit();
            _webDriver.Dispose();
            _webDriver = null;
        }

        public static void MaximizeWindow()
        {
            _webDriver.Manage().Window.Maximize();
        }
    }
}
