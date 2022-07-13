using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium;

namespace Phase4Section1._4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = new ChromeDriver();


            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:51434/");
            By username = By.Id("username");
            IWebElement EMAIL = driver.FindElement(username);
            EMAIL.SendKeys("charan");
            By password = By.Id("password");
            IWebElement PASS = driver.FindElement(password);
            PASS.SendKeys("indra");
            By LOGIN = By.XPath("/html/body/div[2]/div/div/div/div[2]/form/div/center/div/div[7]/div/input");
            IWebElement LOG = driver.FindElement(LOGIN);
            LOG.Click();
            By ORDER = By.Name("compare");
            driver.FindElement(ORDER).Click();
            By CART = By.Id("count");
            IWebElement CART2 = driver.FindElement(CART);
            CART2.Click();

        }
    }
}
