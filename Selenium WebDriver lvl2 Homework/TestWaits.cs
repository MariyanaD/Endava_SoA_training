using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;


namespace BasicSelenium_Project
{
    class TestWaits
    {

        IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);


        }

        [Test]
        public void Test1()
        {
            _driver.Navigate().GoToUrl("http://localhost:8080/login.php");

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
          
            LoginPage logInPage = new LoginPage(_driver);

            logInPage.EnterUserName("admin@automation.com");
            logInPage.EnterPassword("pass123");
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
