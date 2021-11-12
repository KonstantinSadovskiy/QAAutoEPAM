using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace SeleniumWebdriver
{
    public class Waiter
    {
        public static IWebDriver WebDriver { get; set; }

        public static int runOutTime { get; set; }

        public static void WaitForClickableElement(By locator)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(runOutTime)).Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public static void WaitForVisibleElement(By locator)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(runOutTime)).Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public static void WaitForTitle(string title)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(runOutTime)).Until(ExpectedConditions.TitleIs(title));
        }

        public static void WaitPageLoading(double sec)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(sec));
        }
    }
}
