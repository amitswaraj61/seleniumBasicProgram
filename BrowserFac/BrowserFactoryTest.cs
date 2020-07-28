using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasicProgram.BrowserFac
{

    class BrowserFactoryTest
    {
        IWebDriver driver;
        BrowserFactory fact = new BrowserFactory();

        [Test]
        public void BrowserTest()
        {
            driver = fact.InitBrowser("chrome");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com";
            driver.Quit();
        }
    }
}

     