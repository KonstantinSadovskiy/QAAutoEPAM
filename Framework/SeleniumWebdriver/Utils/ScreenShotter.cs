using OpenQA.Selenium;
using System;

namespace SeleniumWebdriver.Utils
{
    public class ScreenShotter
    {
        public static void TakeScreenshot(IWebDriver webDriver)
        {
                string screenshotName = "SeleniumTestingScreenshot - " + DateTime.Now.ToString("yyyy - dd - M--HH - mm - ss") + ".png";

                Screenshot ss = ((ITakesScreenshot)webDriver).GetScreenshot();
                ss.SaveAsFile(@$"Screenshots\{screenshotName}", ScreenshotImageFormat.Png);
        }
    }
}
