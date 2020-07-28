using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumBasicProgram.ParallelProgram
{
    [TestFixture]
    [Parallelizable]
    class ParallelAutomation
    {
        readonly IWebDriver driver;

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod1()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement emailTextFields = Driver.FindElement(By.XPath("//td[1]//input[1]"));
            emailTextFields.SendKeys("aswaraj78@gmail.com");
            Thread.Sleep(2000);
            Driver.Quit();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod2()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement emailTextFields = Driver.FindElement(By.XPath("//td[1]//input[1]"));
            emailTextFields.SendKeys("aswaraj78@gmail.com");
            Thread.Sleep(2000);
            Driver.Quit();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod3()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement emailTextFields = Driver.FindElement(By.XPath("//td[1]//input[1]"));
            emailTextFields.SendKeys("aswaraj78@gmail.com");
            Thread.Sleep(2000);
            Driver.Quit();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod4()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement emailTextFields = Driver.FindElement(By.XPath("//td[1]//input[1]"));
            emailTextFields.SendKeys("aswaraj78@gmail.com");
            Thread.Sleep(2000);
            Driver.Quit();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod5()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement emailTextFields = Driver.FindElement(By.XPath("//td[1]//input[1]"));
            emailTextFields.SendKeys("aswaraj78@gmail.com");
            Thread.Sleep(2000);
            Driver.Quit();
        }
    }
}


