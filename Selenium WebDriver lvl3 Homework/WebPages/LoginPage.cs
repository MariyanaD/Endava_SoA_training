
using OpenQA.Selenium;


namespace BasicSelenium_Project
{
    class LoginPage
    {

        IWebDriver _driver;

        public LoginPage(IWebDriver webDriver)
        {
            _driver = webDriver;
        }

        private IWebElement UserNameField => _driver.FindElement(By.XPath("//*[@name='email']"));
        private IWebElement PasswordField => _driver.FindElement(By.XPath("//*[@name='pass']"));
        private IWebElement SubmitButton => _driver.FindElement(By.XPath("//*[@type='submit']"));

        public void EnterUserName(string userName)
        {
            UserNameField.Clear();
            UserNameField.SendKeys(userName);
        }

        public void EnterPassword(string password)
        {
            PasswordField.Clear();
            PasswordField.SendKeys(password);
        }

        public void ClickSubmitButton()
        {
            SubmitButton.Click();
        }
    }
}