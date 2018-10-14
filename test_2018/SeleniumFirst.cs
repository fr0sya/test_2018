using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace test_2018
{
    [TestFixture]
    class SeleniumFirst
    {
        //private string baseURL;
        //private object verificationErrors;
        private IWebDriver driver;

        [OneTimeSetUp]
        public void BeforeAllMethods()
        {
            //driver = new ChromeDriver();
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [SetUp]
        public void SetUp()
        {
            driver.Navigate().GoToUrl("https://www.google.com.ua/");
        }

        [OneTimeTearDown]
        public void AfterAllMethods()
        {
            driver.Quit();
        }


        [Test]
        public void TheFluxday1Test()
        {
            //IWebDriver driver = new FirefoxDriver();
            //IWebDriver driver = new ChromeDriver();
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.Navigate().GoToUrl("https://www.google.com.ua/");
            //
            driver.FindElement(By.Id("lst-ib")).Click();
            driver.FindElement(By.Id("lst-ib")).Clear();
            driver.FindElement(By.Id("lst-ib")).SendKeys("selenium ide" + Keys.Enter);
            Thread.Sleep(2000);
            //
            driver.FindElement(By.LinkText("Selenium IDE")).Click();
           // Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Download")).Click();
           //
            Assert.AreEqual("Selenium IDE is a Chrome and Firefox plugin which records and plays back user interactions with the browser.", 
                driver.FindElement(By.CssSelector("a[name=\"selenium_ide\"] > p")).Text);
            //
           // driver.Quit();
            
        }
    }
}
