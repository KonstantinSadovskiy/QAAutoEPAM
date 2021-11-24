using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;

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
                switch(TestContext.Parameters["browser"])
                {
                    case "edge":
                        {
                            EdgeOptions options = new EdgeOptions();
                            options.AddArguments("start-maximized");
                            new DriverManager().SetUpDriver(new EdgeConfig());
                            _webDriver = new EdgeDriver(options);
                            break;
                        }
                    case "chrome":
                        {
                            ChromeOptions options = new ChromeOptions();
                            options.AddArguments("start-maximized");
                            new DriverManager().SetUpDriver(new ChromeConfig());
                            _webDriver = new ChromeDriver(options);
                            break;
                        }
                }
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

        public static void GoFullscreenWindow()
        {
            _webDriver.Manage().Window.FullScreen();
        }
    }
}
