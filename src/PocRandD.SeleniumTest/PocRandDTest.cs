// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace PocRandD.SeleniumTest
{
    [TestFixture]
    public class PocRandDTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void pocRandD()
        {
            driver.Navigate().GoToUrl("https://pocselenium.azurewebsites.net/");
            driver.Manage().Window.Size = new System.Drawing.Size(697, 728);
            driver.FindElement(By.LinkText("Privacy")).Click();
            driver.FindElement(By.CssSelector("h1")).Click();
            driver.FindElement(By.LinkText("Home")).Click();
            driver.FindElement(By.CssSelector("h2")).Click();
            driver.FindElement(By.LinkText("Privacy")).Click();
            driver.FindElement(By.LinkText("PocRandD")).Click();
        }
    }

}
