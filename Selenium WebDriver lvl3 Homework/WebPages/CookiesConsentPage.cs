using OpenQA.Selenium;
using System;


namespace BasicSelenium_Project
{
    class CookiesConsentPage
    {
        IWebDriver _driver;

        public CookiesConsentPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement IFrame => _driver.FindElement(By.CssSelector(""));
        private IWebElement AcceptAllCookiesButton=> _driver.FindElement(By.CssSelector(""));

        public void ClickAcceptAll()
        {
            _driver.SwitchTo().Frame(IFrame);
            AcceptAllCookiesButton.Click();
        }
    }
}
