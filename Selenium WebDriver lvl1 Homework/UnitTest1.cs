using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BasicSelenium_Project
{
    public class Tests
    {
      IWebDriver _driver;
              
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            _driver.Navigate().GoToUrl("http://localhost:8080/login.php");
            _driver.Manage().Window.Maximize();

            _driver.FindElement(By.XPath("//*[@name='email']")).Clear();
            _driver.FindElement(By.XPath("//*[@name='email']")).SendKeys("admin@automation.com");

            _driver.FindElement(By.XPath("//*[@name='pass']")).Clear();
            _driver.FindElement(By.XPath("//*[@name='pass']")).SendKeys("pass123");

            _driver.FindElement(By.XPath("//*[@name='btn-login']")).Click();

            Assert.IsTrue(_driver.FindElement(By.XPath("//div[@class='jumbotron']")).Displayed, "Hello,   Admin Automation");
        }
        [TearDown]
        public void DisposeDriver()
        {
            _driver.Dispose();
        }
    }
}