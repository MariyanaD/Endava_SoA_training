using BasicSelenium_Project.Configuration;
using BasicSelenium_Project.TestData;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;


namespace BasicSelenium_Project
{
    class LoginTest
    {

        IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Double.Parse(ConfigurationProviders.GetValue[ConfigurationLabels.DefaultImplicitTimeout]));


        }

        [Test]
        public void Test1()
        {
            _driver.Navigate().GoToUrl(ConfigurationProviders.GetValue[ConfigurationLabels.BaseUrl]);

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
          
            LoginPage logInPage = new LoginPage(_driver);

            logInPage.EnterUserName(UserTestData.DefaultIncorrectUser.UserName);
            logInPage.EnterPassword(UserTestData.DefaultIncorrectUser.Password);
            logInPage.ClickSubmitButton();
           
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(
            By.XPath("//div[@class='jumbotron']")));

            Assert.IsTrue(_driver.FindElement(By.XPath("//div[@class='jumbotron']")).Displayed, "Hello,   Admin Automation");
        }
        [TearDown]
        public void DisposeDriver()
        {
            _driver.Dispose();
        }
    }
}
