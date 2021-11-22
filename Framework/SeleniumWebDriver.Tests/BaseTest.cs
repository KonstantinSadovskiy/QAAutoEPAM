using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumWebdriver.Driver;
using SeleniumWebdriver.Utils;
using NUnit.Framework.Interfaces;

namespace SeleniumWebDriver.Tests
{
    public abstract class BaseTest
    {
        protected IWebDriver _webDriver;

        [SetUp]
        public void Setup()
        {
            _webDriver = DriverSingleton.GetDriver();
            DriverSingleton.MaximizeWindow();
        }

        [TearDown]
        public void QuitDriver()
        {
            if (TestContext.CurrentContext.Result.Outcome == ResultState.Error || TestContext.CurrentContext.Result.Outcome == ResultState.Failure)
            {
                ScreenShotter.TakeScreenshot(_webDriver);
            }

            DriverSingleton.CloseDriver();
        }
    }
}
